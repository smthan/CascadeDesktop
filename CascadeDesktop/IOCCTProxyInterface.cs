﻿using Cascade.Common;
using System;
using System.Collections.Generic;

namespace CascadeDesktop
{
    public interface IOCCTProxyInterface
    {
        void StartZoomAtPoint(int theX1, int theY1);
        void ZoomAtPoint(int theX1, int theY1, int theX2, int theY2);
        Vector3 GetGravityPoint();
        Vector3 GetCenter();
        Vector3 GetEye();
        Vector3 GetUp();
        void ResetSelectionMode();
        ManagedObjHandle Text2Brep(string str, double fontSize, double bevelHeight);
        void SetSelectionMode(OCCTProxy.SelectionModeEnum f);
        void TopView();
        void FrontView();
        ManagedObjHandle GetSelectedObject();
        ManagedObjHandle GetDetectedObject();
        bool IsObjectSelected();
        void SetDisplayMode(int m);
        void Display(ManagedObjHandle m, bool wireframe);
        void InitOCCTProxy();
        void RedrawView();
        void ShowCube();
        void ZoomAllView();
        List<ManagedObjHandle> ImportStep(string path);
        List<ManagedObjHandle> ImportStep(string path, List<byte> stream);
        List<ManagedObjHandle> ImportIges(string path);
        void LeftView();
        void ActivateGrid(bool enabled);
        void AxoView();
        void SetAutoViewerUpdate(bool v);
        ManagedObjHandle MakeFuse(ManagedObjHandle h1, ManagedObjHandle h2);
        ManagedObjHandle MakeDiff(ManagedObjHandle h1, ManagedObjHandle h2);
        ManagedObjHandle MakeCommon(ManagedObjHandle h1, ManagedObjHandle h2);
        void MoveObject(ManagedObjHandle h1, double x, double y, double z, bool rel);
        void RotateObject(ManagedObjHandle h1, double x, double y, double z, double rot, bool rel);
        void Erase(ManagedObjHandle h1, bool updateViewer = true);
        void Remove(ManagedObjHandle h1);
        void UpdateView();
        void UpdateCurrentViewer();
        void SetTransparency(ManagedObjHandle managedObjHandle, double v);
        ManagedObjHandle MakePrismFromFace(ManagedObjHandle managedObjHandle, double height);
        List<SurfInfo> GetFacesInfo(ManagedObjHandle managedObjHandle);
        List<EdgeInfo> GetEdgesInfo(ManagedObjHandle managedObjHandle);
        void SetDefaultGradient();
        void BackView();
        void BottomView();
        void RightView();
        void SetColor(ManagedObjHandle h, int red, int green, int blue);
        List<double> GetObjectMatrixValues(ManagedObjHandle h);
        void SetMatrixValues(ManagedObjHandle h, List<double> m);
        ManagedObjHandle MakeCone(double r1, double r2, double h);
        ManagedObjHandle MakeChamfer(ManagedObjHandle so, double r);
        ManagedObjHandle MakePrism(ManagedObjHandle managedObjHandle, double h);
        ManagedObjHandle Clone(ManagedObjHandle so);
        ManagedObjHandle MakeFillet(ManagedObjHandle so, double r);
        ManagedObjHandle MakeFillet2d(ManagedObjHandle so, double r);
        ManagedObjHandle HelixWire(double radius, double radius2, double pitch,double sweep);
        ManagedObjHandle MakePipe(ManagedObjHandle so, double r);
        ManagedObjHandle Pipe(double x1, double y1, double z1, double x2, double y2, double z2, double size);
        ManagedObjHandle Sphere(double x1, double y1, double z1, double size);
        ManagedObjHandle MirrorObject(ManagedObjHandle managedObjHandle, Vector3 dir, Vector3 pnt, bool axis2, bool rel);
        ManagedObjHandle MakeSphere(double r);
        ManagedObjHandle MakeCylinder(double r, double h);
        bool ExportStep(ManagedObjHandle managedObjHandle, string fileName);
        List<byte> ExportStepStream(ManagedObjHandle managedObjHandle);
        void MoveTo(int x, int y);
        void Pan(int x, int y);
        void Rotation(int x, int y);
        ManagedObjHandle MakeBox(double x, double y, double z, double w, double l, double h);
        void SetBackgroundColor(int r1, int g1, int b1, int r2, int g2, int b2);
        bool InitViewer(IntPtr handle);
        void SetMaterial(int v);
        void Zoom(int v1, int v2, int v3, int v4);
        EdgeInfo GetEdgeInfoPosition(ManagedObjHandle obj);
        SurfInfo GetFaceInfo(ManagedObjHandle obj);
        Vector3 GetVertexPosition(ManagedObjHandle obj);
        void StartRotation(int x, int y);
        void Select(bool v);
        List<Vector3> IteratePoly(ManagedObjHandle managedObjHandle);
        ManagedObjHandle AddWireDraft(double height);
        ManagedObjHandle ImportBlueprint(Blueprint blueprint);
        ManagedObjHandle ImportBlueprint(Blueprint3d blueprint);

    }
}
