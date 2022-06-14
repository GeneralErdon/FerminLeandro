Public Class Titulos
    Dim fila As DataRow
    Dim accion As String = ""

    'DECLARACIÓN DE MÉTODOS
    Private Sub inicio()
        comboEditorial.Enabled = False
        DTPFecha.Enabled = False
        ' ME QUEDÉ POR HACER ESTO   EL METODO DE INICIO
        BEliminar.Enabled = False
        BCancelar.Enabled = False
        BBuscar.Enabled = True
        BAgregar.Enabled = True
        BGuardar.Enabled = False
        BModificar.Enabled = False

        txtCodigo.Enabled = True
        txtCodigo.Focus()

        txtTitulo.ReadOnly = True
        txtTipo.ReadOnly = True
        txtPrecio.ReadOnly = True
        txtAdelanto.ReadOnly = True
        txtDerechos.ReadOnly = True
        txtNotas.ReadOnly = True
        txtVentas.ReadOnly = True
        txtCodEditorial.ReadOnly = True

    End Sub
    Private Sub reload()
        DsTitulos1.Clear()
        DAEditorial.Fill(DsTitulos1.publishers)
        DATitles.Fill(DsTitulos1.titles)
    End Sub
    Private Sub habilitar()
        txtTitulo.ReadOnly = False
        txtTipo.ReadOnly = False
        txtPrecio.ReadOnly = False
        txtAdelanto.ReadOnly = False
        txtDerechos.ReadOnly = False
        txtNotas.ReadOnly = False
        txtVentas.ReadOnly = False
        txtCodEditorial.ReadOnly = False

        comboEditorial.Enabled = True
        DTPFecha.Enabled = True

        txtTitulo.Focus()

    End Sub

    Private Sub BuscarFila()
        fila = DsTitulos1.titles.Rows.Find(Trim(txtCodigo.Text))
    End Sub
    Private Sub mostrarfila()
        txtTitulo.Text = fila(1)
        txtTipo.Text = fila(2)

        If Not IsDBNull(fila(4)) Then
            txtPrecio.Text = fila(4)
        End If
        If Not IsDBNull(fila(3)) Then
            comboEditorial.SelectedValue = DsTitulos1.publishers.FindBypub_id(fila(3)).pub_id
            txtCodEditorial.Text = DsTitulos1.publishers.FindBypub_id(fila(3)).pub_id
        End If
        If Not IsDBNull(fila(5)) Then
            txtAdelanto.Text = fila(5)
        End If
        If Not IsDBNull(fila(6)) Then
            txtDerechos.Text = fila(6)
        End If
        If Not IsDBNull(fila(7)) Then
            txtVentas.Text = fila(7)
        End If
        If Not IsDBNull(fila(8)) Then
            txtNotas.Text = fila(8)
        End If
        DTPFecha.Value = fila(9)

        BEliminar.Enabled = True
        BModificar.Enabled = True

    End Sub

    Private Sub agregarFila()

        Try
            fila = DsTitulos1.titles.NewRow

            fila(0) = txtCodigo.Text
            fila(1) = txtTitulo.Text
            fila(2) = txtTipo.Text
            fila(3) = txtCodEditorial.Text
            fila(4) = txtPrecio.Text
            fila(5) = txtAdelanto.Text
            fila(6) = txtDerechos.Text
            fila(7) = txtVentas.Text
            fila(8) = txtNotas.Text
            fila(9) = DTPFecha.Value

            DsTitulos1.titles.Rows.Add(fila)
            DATitles.Update(DsTitulos1, "titles")
            DsTitulos1.titles.AcceptChanges()

            MsgBox("Registro agregado", MsgBoxStyle.Information, "Nuevo Registro")
        Catch ex As Exception
            MsgBox("Exception: " + ex.ToString, MsgBoxStyle.Critical, "Error")
            reload()

        End Try


    End Sub

    Private Sub eliminarFila()
        Try
            DsTitulos1.titles.FindBytitle_id(Trim(txtCodigo.Text)).Delete()
            DATitles.Update(DsTitulos1, "titles")
            DsTitulos1.AcceptChanges()
            MsgBox("Registro eliminado", MsgBoxStyle.Information, "Eliminar")
        Catch ex As Exception
            MsgBox("Exception: " + ex.ToString, MsgBoxStyle.Critical, "Error")
            reload()
        End Try
    End Sub

    Private Sub modificarTabla()
        Try
            With DsTitulos1.titles.FindBytitle_id(Trim(txtCodigo.Text))
                .title = txtTitulo.Text
                .advance = txtAdelanto.Text
                .notes = txtNotas.Text
                .price = txtPrecio.Text
                .pubdate = DTPFecha.Value
                .pub_id = txtCodEditorial.Text
                .royalty = txtDerechos.Text
                .type = txtTipo.Text
                .ytd_sales = txtVentas.Text
            End With
            DATitles.Update(DsTitulos1, "titles")
            DsTitulos1.AcceptChanges()
            MsgBox("Fila modificada satisfactoriamente", MsgBoxStyle.Information, "Tabla")

        Catch ex As Exception
            MsgBox("Exception: " + ex.ToString, MsgBoxStyle.Critical, "Error")
            reload()
        End Try
    End Sub

    Private Sub Titulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload()
        inicio()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BSalir.Click

        If MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Salir") = vbYes Then
            Close()
        End If

    End Sub

    Private Sub comboEditorial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboEditorial.SelectedIndexChanged
        If accion.ToLower = "agregar" Or accion.ToLower = "modificar" Then
            txtCodEditorial.Text = comboEditorial.SelectedValue
        End If
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        If txtCodigo.Text = "" Then
            MsgBox("Ingrese el código a agregar", MsgBoxStyle.Critical, "Titles")
            txtCodigo.Focus()
        Else
            accion = "agregar"
            BAgregar.Enabled = False
            BBuscar.Enabled = False
            BGuardar.Enabled = True
            BCancelar.Enabled = True
            txtCodigo.Enabled = False
            BuscarFila()
            If fila Is Nothing Then
                habilitar()
            Else
                MsgBox("Código ya registrado", MsgBoxStyle.Information, "Nombre de la tabla ")
                inicio()
            End If
        End If
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If txtCodigo.Text = "" Then
            MsgBox("Ingrese el código a buscar", MsgBoxStyle.Critical, "Nombre de la tabla")
            txtCodigo.Focus()
        Else
            accion = "buscar"
            BAgregar.Enabled = False
            BBuscar.Enabled = False
            BCancelar.Enabled = True
            txtCodigo.Enabled = False
            BuscarFila()
            If fila Is Nothing Then
                MsgBox("Código no registrado", MsgBoxStyle.Information, "Nombre de la tabla ")
                Dim respuesta As MsgBoxResult
                respuesta = MsgBox("¿Desea agregar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "nombre de la tabla")
                If respuesta = MsgBoxResult.Yes Then
                    accion = "agregar"
                    habilitar()

                Else
                    inicio()
                End If
            Else
                mostrarfila()
            End If
        End If

    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        accion = "modificar"
        BModificar.Enabled = False
        BEliminar.Enabled = False
        BGuardar.Enabled = True
        habilitar()
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Está seguro que desea eliminar?", MsgBoxStyle.YesNo +
        MsgBoxStyle.Question, "nombre de la tabla")
        If respuesta = MsgBoxResult.Yes Then
            eliminarFila()
        End If
        inicio()
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If accion.ToLower = "agregar" Then
            agregarFila()
        End If
        If accion.ToUpper = "MODIFICAR" Then
            modificarTabla()
        End If
        inicio()
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        inicio()

    End Sub
End Class
