﻿Public Class PHIEUTHUTIENDTO
    Private maPhieuThu As Integer
    Private maKH As Integer
    Private ngayThuTien As DateTime
    Private soTienThu As Integer
    Public Sub New()

    End Sub
    Public Sub New(maPhieuThu As Integer, maKH As Integer, ngayThuTien As DateTime, soTienThu As Integer)
        Me.MaPhieuThu1 = maPhieuThu
        Me.MaKH1 = maKH
        Me.NgayThuTien1 = ngayThuTien
        Me.SoTienThu1 = soTienThu
    End Sub

    Public Property MaPhieuThu1 As Integer
        Get
            Return maPhieuThu
        End Get
        Set(value As Integer)
            maPhieuThu = value
        End Set
    End Property

    Public Property MaKH1 As Integer
        Get
            Return maKH
        End Get
        Set(value As Integer)
            maKH = value
        End Set
    End Property

    Public Property NgayThuTien1 As Date
        Get
            Return ngayThuTien
        End Get
        Set(value As Date)
            ngayThuTien = value
        End Set
    End Property

    Public Property SoTienThu1 As Integer
        Get
            Return soTienThu
        End Get
        Set(value As Integer)
            soTienThu = value
        End Set
    End Property
End Class
