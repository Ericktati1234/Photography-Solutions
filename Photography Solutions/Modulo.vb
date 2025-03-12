﻿
Imports System.Globalization

Module Modulo
    Public NombrePaciente As String
    Public PaternoPaciente As String
    Public MaternoPaciente As String
    Public GeneroPaciente As String
    Public NacimientoPaciente As String
    Public IdPaciente As Integer
    Public NombreUsuario As String
    Public CedulaUsuario As String
    Public EspecialidadUsuario As String
    Public IdUsuario As Integer
    Public idReceta As Integer
    Public idDoctor As Integer

    Public Function EsEntero(valor As String) As Boolean
        Dim numero As Integer
        If Integer.TryParse(valor, numero) AndAlso numero >= 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function EsDouble(valor As String) As Boolean
        Dim numero As Double
        If Double.TryParse(valor, numero) AndAlso numero >= 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function ValidarFecha(fecha As String) As Boolean
        Dim dt As DateTime
        Dim formato As String = "dd/MM/yyyy"
        Dim esFechaValida As Boolean = DateTime.TryParseExact(fecha, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, dt)

        Return esFechaValida
    End Function
    Public sqlConexion As SqlClient.SqlConnection

    Sub LlenaGrid(ByVal sqlcConexion As SqlClient.SqlConnection, ByVal dgvDatos As DataGridView, ByVal strConsulta As String)
        Dim sqldaAdaptador As New SqlClient.SqlDataAdapter
        Dim sqlcmdComando As New SqlClient.SqlCommand(strConsulta)
        Dim sqldsConjunto As New DataSet
        sqlcmdComando.CommandTimeout = 0
        sqldaAdaptador.SelectCommand = sqlcmdComando
        sqldaAdaptador.SelectCommand.Connection = sqlcConexion
        sqldaAdaptador.Fill(sqldsConjunto, "Tabla")
        dgvDatos.DataSource = sqldsConjunto.Tables("Tabla")

    End Sub

    Sub llenaCombo(strConsulta As String, combo As ComboBox, Id As String, descripcion As String, sqlCon As SqlClient.SqlConnection)
        Dim da As New SqlClient.SqlDataAdapter(strConsulta, sqlCon)
        Dim ds As New DataSet
        da.Fill(ds)
        combo.DataSource = ds.Tables(0)
        combo.DisplayMember = descripcion
        combo.ValueMember = Id
    End Sub


    Public Function llenarDataSet(ByRef csql As String, ByRef DS As Data.DataSet, ByVal tabla As String, ByVal db As SqlClient.SqlConnection, Optional ByRef Da As SqlClient.SqlDataAdapter = Nothing) As Boolean
        If String.IsNullOrEmpty(csql) OrElse DS Is Nothing OrElse String.IsNullOrEmpty(tabla) OrElse db Is Nothing Then
            Throw New ArgumentNullException("Parámetros nulos no permitidos")
        End If

        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlcmdcomando As New SqlClient.SqlCommand(csql, db)
        sqlcmdcomando.CommandTimeout = 5000
        sqla.SelectCommand = sqlcmdcomando

        Try
            If Da IsNot Nothing Then
                Da = sqla
                Da.MissingSchemaAction = MissingSchemaAction.AddWithKey
                Da.Fill(DS, tabla)
            Else
                sqla.Fill(DS, tabla)
            End If

            Return True
        Catch exSQLClient As SqlClient.SqlException
            MessageBox.Show("Numero de Error :" & exSQLClient.Number.ToString() & vbCrLf & "Fuente: " & exSQLClient.Source & vbCrLf & vbCrLf & exSQLClient.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Catch ex As Exception
            MessageBox.Show("Numero de Error :" & Err.Number.ToString() & vbCrLf & "Fuente: " & Err.Source & vbCrLf & vbCrLf & Err.Description, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module
