﻿'------------------------------------------------------------------------------
' <auto-generated>
'    Este código se generó a partir de una plantilla.
'
'    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class InformaticaEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=InformaticaEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property Categorias() As DbSet(Of Categorias)
    Public Property Empleados() As DbSet(Of Empleados)
    Public Property Marcas() As DbSet(Of Marcas)
    Public Property Origen_Producto() As DbSet(Of Origen_Producto)
    Public Property Productos() As DbSet(Of Productos)
    Public Property Proveedores() As DbSet(Of Proveedores)
    Public Property Provincia() As DbSet(Of Provincia)
    Public Property sysdiagrams() As DbSet(Of sysdiagrams)
    Public Property tipoUsuario() As DbSet(Of tipoUsuario)
    Public Property Usuarios() As DbSet(Of Usuarios)

End Class