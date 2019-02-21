using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.ADF.COMSupport;
using ESRI.ArcGIS.ADF.Serialization;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.DataSourcesRaster;
using System.Runtime.InteropServices;

namespace WaterMarkerAE
{
    class DataRead
    {
        public List<ILayer> ReadShapLayer(List<string> filePathList)
        {
            List<ILayer> layerList = new List<ILayer>();

            if (filePathList.Count == 0) return null;
            else
            {
                foreach (string path in filePathList)
                {
                    IWorkspaceFactory pWorkspaceFactory = new ShapefileWorkspaceFactory();
                    IWorkspace pWorkspace = pWorkspaceFactory.OpenFromFile(System.IO.Path.GetDirectoryName(path), 0);
                    IFeatureWorkspace pFeatureWorkspace = pWorkspace as IFeatureWorkspace;

                    IFeatureClass pFeatureClass = pFeatureWorkspace.OpenFeatureClass(System.IO.Path.GetFileNameWithoutExtension(path));
                    IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                    pFeatureLayer.FeatureClass = pFeatureClass;
                    pFeatureLayer.Name = System.IO.Path.GetFileNameWithoutExtension(path);
                    layerList.Add(pFeatureLayer as ILayer);
                }
                return layerList;
            }
        }
        
        //读取mdb数据
        public List<ILayer> ReadLayerFromAccess(List<string> filePathList)
        {
            List<ILayer> layerList = new List<ILayer>();

            if (filePathList.Count == 0) return null;
            else
            {
                foreach (string path in filePathList)
                {
                    IWorkspaceFactory pWorkspaceFactory = new AccessWorkspaceFactoryClass();
                    IWorkspace pWorkspace = pWorkspaceFactory.OpenFromFile(path, 0);
                    IFeatureWorkspace pFeatureWorkspace = pWorkspace as IFeatureWorkspace;

                    IEnumDataset pEnumDataset = pWorkspace.get_Datasets(esriDatasetType.esriDTFeatureClass) as IEnumDataset;
                    pEnumDataset.Reset();
                    IDataset pDataset = pEnumDataset.Next();

                    while (pDataset is IFeatureClass)
                    {
                        IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                        pFeatureLayer.FeatureClass = pFeatureWorkspace.OpenFeatureClass(pDataset.Name);
                        pFeatureLayer.Name = pDataset.Name;
                        ILayer pLayer = pFeatureLayer as ILayer;
                        layerList.Add(pFeatureLayer as ILayer);
                        pDataset = pEnumDataset.Next();
                    }
                }
                return layerList;
            }
        }

        //读取GDB数据
        public List<ILayer> ReadLayerFromGDB(List<string> filePathList)
        {
            List<ILayer> layerList = new List<ILayer>();
            string waterMarker = "1111100000";
            if (filePathList.Count == 0) return null;
            else
            {
                foreach (string path in filePathList)
                {
                    IWorkspaceFactory pWorkspaceFactory = new FileGDBWorkspaceFactoryClass();
                    IWorkspace pWorkspace = pWorkspaceFactory.OpenFromFile(path, 0);
                    IFeatureWorkspace pFeatureWorkspace = pWorkspace as IFeatureWorkspace;                    
                    IEnumDataset pEnumDataset = pWorkspace.get_Datasets(esriDatasetType.esriDTAny) as IEnumDataset;
                    pEnumDataset.Reset();
                    IDataset pDataset = pEnumDataset.Next();
                    IWorkspace workspace = pDataset.Workspace;
                    IWorkspaceEdit workspaceEdit = (IWorkspaceEdit)workspace;
                    workspaceEdit.StartEditing(true);
                    workspaceEdit.StartEditOperation();
                    while (pDataset is IFeatureClass)
                    {

                        IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                        pFeatureLayer.FeatureClass = pFeatureWorkspace.OpenFeatureClass(pDataset.Name);
                        pFeatureLayer.Name = pDataset.Name;
                        //添加嵌入水印的功能
                        List<IPoint> points = new List<IPoint>();
                        if (pFeatureLayer != null && pFeatureLayer.FeatureClass.FeatureCount(null) != 1)
                        {
                            IFeatureCursor featureCursor = pFeatureLayer.Search(null, false);
                            IFeature pFeature = featureCursor.NextFeature();//遍历查询结果
                            while (pFeature != null)
                            {
                                IPointCollection pointColl = null;
                                switch (pFeature.Shape.GeometryType)
                                {
                                    case esriGeometryType.esriGeometryPoint:
                                        (pFeature.Shape as Point).PutCoords(0, 0);
                                        points.Add(pFeature.Shape as Point);
                                        break;
                                    case esriGeometryType.esriGeometryMultipoint:
                                        points.Add(pFeature.Shape as Point);
                                        break;
                                    case esriGeometryType.esriGeometryLine:
                                    case esriGeometryType.esriGeometryPolyline:
                                        pointColl = (pFeature.Shape) as IPointCollection;
                                        int n = 10;
                                        if (pointColl.PointCount > 10)
                                            n = 10;
                                        else
                                            n = pointColl.PointCount;
                                        for (int m = 0; m < pointColl.PointCount; m++)
                                        {
                                            IPoint point = pointColl.get_Point(m);
                                            point.X = 4000000.00000001;
                                            (pFeature.Shape as IPointCollection).UpdatePoint(m, point);
                                        }
                                        pFeature.Shape = (IGeometry)pointColl;
                                        pFeature.Store();
                                        break;
                                    case esriGeometryType.esriGeometryPolygon:
                                        pointColl = (pFeature.Shape) as IPointCollection;
                                        int k = 10;
                                        if (pointColl.PointCount > 10)
                                            k = 10;
                                        else
                                            k = pointColl.PointCount;
                                        for (int m = 0; m < pointColl.PointCount; m++)
                                        {
                                            IPoint point = pointColl.get_Point(m);
                                            point.X = 4000000.00000001;
                                            (pFeature.Shape as IPointCollection).UpdatePoint(m, point);
                                        }
                                        pFeature.Shape = (IGeometry)pointColl;
                                        pFeature.Store();
                                        break;
                                    default:
                                        break;
                                }
                                if (pointColl == null)
                                    continue;
                                pFeature = featureCursor.NextFeature();
                            }

                            ILayer pLayer = pFeatureLayer as ILayer;
                            layerList.Add(pFeatureLayer as ILayer);
                        }

                        pDataset = pEnumDataset.Next();
                    }

                    Marshal.ReleaseComObject(pWorkspaceFactory);
                }
                return layerList;
            }
        }


        //读取水印时参考这个
        public List<ILayer> ReadLayerWATERMARKERFromGDB(List<string> filePathList)
        {
            List<ILayer> layerList = new List<ILayer>();
            string waterMarker = "1111100000";
            if (filePathList.Count == 0) return null;
            else
            {
                foreach (string path in filePathList)
                {
                    IWorkspaceFactory pWorkspaceFactory = new FileGDBWorkspaceFactoryClass();
                    IWorkspace pWorkspace = pWorkspaceFactory.OpenFromFile(path, 0);
                    IFeatureWorkspace pFeatureWorkspace = pWorkspace as IFeatureWorkspace;

                    IEnumDataset pEnumDataset = pWorkspace.get_Datasets(esriDatasetType.esriDTFeatureClass) as IEnumDataset;
                    pEnumDataset.Reset();
                    IDataset pDataset = pEnumDataset.Next();
                    while (pDataset is IFeatureClass)
                    {
                        //using(ESRI.ArcGIS.ADF.ComReleaser comReleaser = new ESRI.ArcGIS.ADF.ComReleaser())
                        IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                        pFeatureLayer.FeatureClass = pFeatureWorkspace.OpenFeatureClass(pDataset.Name);
                        pFeatureLayer.Name = pDataset.Name;
                        //添加嵌入水印的功能
                        List<IPoint> points = new List<IPoint>();
                        if (pFeatureLayer != null && pFeatureLayer.FeatureClass.FeatureCount(null) != 1)
                        {
                            IFeatureCursor featureCursor = pFeatureLayer.Search(null, false);
                            IFeature pFeature = featureCursor.NextFeature();//遍历查询结果
                            while (pFeature != null)
                            {
                                IPointCollection pointColl = null;
                                switch (pFeature.Shape.GeometryType)
                                {
                                    case esriGeometryType.esriGeometryPoint:
                                        points.Add(pFeature.Shape as Point);
                                        break;
                                    case esriGeometryType.esriGeometryMultipoint:
                                        points.Add(pFeature.Shape as Point);
                                        break;
                                    case esriGeometryType.esriGeometryLine:
                                    case esriGeometryType.esriGeometryPolyline:
                                        pointColl = (pFeature.Shape) as IPointCollection;
                                        break;
                                    case esriGeometryType.esriGeometryPolygon:
                                    case esriGeometryType.esriGeometryEnvelope:
                                        pointColl = (pFeature.Shape) as IPointCollection;
                                        break;
                                    default:
                                        break;
                                }
                                if (pointColl == null)
                                    continue;
                                for (int k = 0; k < pointColl.PointCount; k++)
                                {
                                    points.Add(pointColl.get_Point(k));
                                }
                                pFeature = featureCursor.NextFeature();
                            }

                        }
                        Complex[] pointComplex = new Complex[points.Count];
                        //复数序列
                        for (int j = 0; j < points.Count; j++)
                        {
                            pointComplex[j] = new Complex(points[j].X, points[j].Y);
                        }

                        ILayer pLayer = pFeatureLayer as ILayer;
                        layerList.Add(pFeatureLayer as ILayer);
                        pDataset = pEnumDataset.Next();
                    }
                }
                return layerList;
            }
        }

        public  List<ILayer> ReadRasterLayer(List<string> filePathList)
        {
            List<ILayer> layerList = new List<ILayer>();

            if (filePathList.Count == 0) return null;
            else
            {
                foreach (string path in filePathList)
                {
                    IRasterLayer pRasterLayer = new RasterLayerClass();
                    pRasterLayer.CreateFromFilePath(path);
                    layerList.Add(pRasterLayer as ILayer);
                }

                return layerList;
            }
        }

        public  List<ILayer> ReadCADLayer(List<string> filePathList)
        {
            List<ILayer> layerList = new List<ILayer>();

            if (filePathList.Count == 0) return null;
            else
            {
                foreach (string path in filePathList)
                {
                    IWorkspaceFactory pWorkspaceFactory = new CadWorkspaceFactoryClass();
                    IFeatureWorkspace pFeatureWorkspace = pWorkspaceFactory.OpenFromFile(System.IO.Path.GetDirectoryName(path), 0) as IFeatureWorkspace;
                    IFeatureDataset pFeatureDataset = pFeatureWorkspace.OpenFeatureDataset(System.IO.Path.GetFileName(path));
                    IFeatureClassContainer pFeatClassContainer = pFeatureDataset as IFeatureClassContainer;

                    for (int i = 0; i < pFeatClassContainer.ClassCount - 1; i++)
                    {
                        IFeatureLayer pFeatureLayer;
                        IFeatureClass pFeatClass = pFeatClassContainer.get_Class(i);
                        if (pFeatClass.FeatureType == esriFeatureType.esriFTCoverageAnnotation) pFeatureLayer = new CadAnnotationLayerClass();
                        else pFeatureLayer = new FeatureLayerClass();

                        pFeatureLayer.Name = pFeatClass.AliasName;
                        pFeatureLayer.FeatureClass = pFeatClass;
                        layerList.Add(pFeatureLayer as ILayer);
                    }
                }
                return layerList;
            }
        }

    }
}
