<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Titulos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Titulos))
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.comboEditorial = New System.Windows.Forms.ComboBox()
        Me.DsTitulos1 = New FerminLeandro.DSTitulos()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodEditorial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAdelanto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDerechos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVentas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.DATitles = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.DAEditorial = New System.Data.SqlClient.SqlDataAdapter()
        CType(Me.DsTitulos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(46, 54)
        Me.txtCodigo.MaxLength = 6
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(122, 26)
        Me.txtCodigo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código del Titulo"
        '
        'BAgregar
        '
        Me.BAgregar.Location = New System.Drawing.Point(171, 404)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(87, 31)
        Me.BAgregar.TabIndex = 2
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'comboEditorial
        '
        Me.comboEditorial.DataSource = Me.DsTitulos1
        Me.comboEditorial.DisplayMember = "publishers.pub_name"
        Me.comboEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboEditorial.FormattingEnabled = True
        Me.comboEditorial.Location = New System.Drawing.Point(37, 327)
        Me.comboEditorial.Name = "comboEditorial"
        Me.comboEditorial.Size = New System.Drawing.Size(168, 28)
        Me.comboEditorial.TabIndex = 3
        Me.comboEditorial.ValueMember = "publishers.pub_id"
        '
        'DsTitulos1
        '
        Me.DsTitulos1.DataSetName = "DSTitulos"
        Me.DsTitulos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(46, 122)
        Me.txtTitulo.MaxLength = 80
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(201, 26)
        Me.txtTitulo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Título"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(268, 122)
        Me.txtTipo.MaxLength = 12
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(122, 26)
        Me.txtTipo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo"
        '
        'txtCodEditorial
        '
        Me.txtCodEditorial.Location = New System.Drawing.Point(223, 327)
        Me.txtCodEditorial.MaxLength = 4
        Me.txtCodEditorial.Name = "txtCodEditorial"
        Me.txtCodEditorial.Size = New System.Drawing.Size(122, 26)
        Me.txtCodEditorial.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Editorial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cód. Editorial"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(417, 122)
        Me.txtPrecio.MaxLength = 252
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(122, 26)
        Me.txtPrecio.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(413, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Precio"
        '
        'txtAdelanto
        '
        Me.txtAdelanto.Location = New System.Drawing.Point(570, 122)
        Me.txtAdelanto.MaxLength = 252
        Me.txtAdelanto.Name = "txtAdelanto"
        Me.txtAdelanto.Size = New System.Drawing.Size(122, 26)
        Me.txtAdelanto.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(566, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Adelanto"
        '
        'txtDerechos
        '
        Me.txtDerechos.Location = New System.Drawing.Point(46, 211)
        Me.txtDerechos.MaxLength = 252
        Me.txtDerechos.Name = "txtDerechos"
        Me.txtDerechos.Size = New System.Drawing.Size(122, 26)
        Me.txtDerechos.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "% de Derecho de Autor"
        '
        'txtVentas
        '
        Me.txtVentas.Location = New System.Drawing.Point(211, 211)
        Me.txtVentas.MaxLength = 252
        Me.txtVentas.Name = "txtVentas"
        Me.txtVentas.Size = New System.Drawing.Size(122, 26)
        Me.txtVentas.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(207, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Venta Total"
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(372, 211)
        Me.txtNotas.MaxLength = 200
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(320, 88)
        Me.txtNotas.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(370, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Notas"
        '
        'DTPFecha
        '
        Me.DTPFecha.Location = New System.Drawing.Point(417, 327)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(229, 26)
        Me.DTPFecha.TabIndex = 20
        '
        'BBuscar
        '
        Me.BBuscar.Location = New System.Drawing.Point(292, 404)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(87, 31)
        Me.BBuscar.TabIndex = 21
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'BModificar
        '
        Me.BModificar.Location = New System.Drawing.Point(407, 404)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(87, 31)
        Me.BModificar.TabIndex = 22
        Me.BModificar.Text = "Modificar"
        Me.BModificar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(524, 404)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(87, 31)
        Me.BEliminar.TabIndex = 23
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(223, 441)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(87, 31)
        Me.BGuardar.TabIndex = 24
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(347, 441)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(87, 31)
        Me.BCancelar.TabIndex = 25
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(467, 441)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(87, 31)
        Me.BSalir.TabIndex = 26
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        titles.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            titles"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=localhost;Initial Catalog=pubs;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@title_id", System.Data.SqlDbType.VarChar, 0, "title_id"), New System.Data.SqlClient.SqlParameter("@title", System.Data.SqlDbType.VarChar, 0, "title"), New System.Data.SqlClient.SqlParameter("@type", System.Data.SqlDbType.[Char], 0, "type"), New System.Data.SqlClient.SqlParameter("@pub_id", System.Data.SqlDbType.[Char], 0, "pub_id"), New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 0, "price"), New System.Data.SqlClient.SqlParameter("@advance", System.Data.SqlDbType.Money, 0, "advance"), New System.Data.SqlClient.SqlParameter("@royalty", System.Data.SqlDbType.Int, 0, "royalty"), New System.Data.SqlClient.SqlParameter("@ytd_sales", System.Data.SqlDbType.Int, 0, "ytd_sales"), New System.Data.SqlClient.SqlParameter("@notes", System.Data.SqlDbType.VarChar, 0, "notes"), New System.Data.SqlClient.SqlParameter("@pubdate", System.Data.SqlDbType.DateTime, 0, "pubdate")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@title_id", System.Data.SqlDbType.VarChar, 0, "title_id"), New System.Data.SqlClient.SqlParameter("@title", System.Data.SqlDbType.VarChar, 0, "title"), New System.Data.SqlClient.SqlParameter("@type", System.Data.SqlDbType.[Char], 0, "type"), New System.Data.SqlClient.SqlParameter("@pub_id", System.Data.SqlDbType.[Char], 0, "pub_id"), New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 0, "price"), New System.Data.SqlClient.SqlParameter("@advance", System.Data.SqlDbType.Money, 0, "advance"), New System.Data.SqlClient.SqlParameter("@royalty", System.Data.SqlDbType.Int, 0, "royalty"), New System.Data.SqlClient.SqlParameter("@ytd_sales", System.Data.SqlDbType.Int, 0, "ytd_sales"), New System.Data.SqlClient.SqlParameter("@notes", System.Data.SqlDbType.VarChar, 0, "notes"), New System.Data.SqlClient.SqlParameter("@pubdate", System.Data.SqlDbType.DateTime, 0, "pubdate"), New System.Data.SqlClient.SqlParameter("@Original_title_id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "title_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_title", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "title", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_type", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pub_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pub_id", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pub_id", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pub_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_price", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_advance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "advance", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_advance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "advance", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_royalty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "royalty", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_royalty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "royalty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ytd_sales", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ytd_sales", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ytd_sales", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ytd_sales", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_notes", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pubdate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pubdate", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_title_id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "title_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_title", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "title", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_type", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pub_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pub_id", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pub_id", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pub_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_price", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_advance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "advance", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_advance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "advance", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_royalty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "royalty", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_royalty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "royalty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ytd_sales", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ytd_sales", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ytd_sales", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ytd_sales", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_notes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "notes", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_notes", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pubdate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pubdate", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DATitles
        '
        Me.DATitles.DeleteCommand = Me.SqlDeleteCommand1
        Me.DATitles.InsertCommand = Me.SqlInsertCommand1
        Me.DATitles.SelectCommand = Me.SqlSelectCommand1
        Me.DATitles.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "titles", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("title_id", "title_id"), New System.Data.Common.DataColumnMapping("title", "title"), New System.Data.Common.DataColumnMapping("type", "type"), New System.Data.Common.DataColumnMapping("pub_id", "pub_id"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("advance", "advance"), New System.Data.Common.DataColumnMapping("royalty", "royalty"), New System.Data.Common.DataColumnMapping("ytd_sales", "ytd_sales"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pubdate", "pubdate")})})
        Me.DATitles.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        pub_id, pub_name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            publishers"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO [publishers] ([pub_id], [pub_name]) VALUES (@pub_id, @pub_name);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SEL" &
    "ECT pub_id, pub_name FROM publishers WHERE (pub_id = @pub_id)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pub_id", System.Data.SqlDbType.[Char], 0, "pub_id"), New System.Data.SqlClient.SqlParameter("@pub_name", System.Data.SqlDbType.VarChar, 0, "pub_name")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pub_id", System.Data.SqlDbType.[Char], 0, "pub_id"), New System.Data.SqlClient.SqlParameter("@pub_name", System.Data.SqlDbType.VarChar, 0, "pub_name"), New System.Data.SqlClient.SqlParameter("@Original_pub_id", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pub_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pub_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pub_name", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pub_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pub_name", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM [publishers] WHERE (([pub_id] = @Original_pub_id) AND ((@IsNull_pub_n" &
    "ame = 1 AND [pub_name] IS NULL) OR ([pub_name] = @Original_pub_name)))"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_pub_id", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pub_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pub_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pub_name", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pub_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pub_name", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DAEditorial
        '
        Me.DAEditorial.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAEditorial.InsertCommand = Me.SqlInsertCommand2
        Me.DAEditorial.SelectCommand = Me.SqlSelectCommand2
        Me.DAEditorial.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "publishers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pub_id", "pub_id"), New System.Data.Common.DataColumnMapping("pub_name", "pub_name")})})
        Me.DAEditorial.UpdateCommand = Me.SqlUpdateCommand2
        '
        'Titulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 491)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.DTPFecha)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtVentas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDerechos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAdelanto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodEditorial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.comboEditorial)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Titulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Títulos"
        CType(Me.DsTitulos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BAgregar As Button
    Friend WithEvents comboEditorial As ComboBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodEditorial As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAdelanto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDerechos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVentas As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNotas As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DTPFecha As DateTimePicker
    Friend WithEvents BBuscar As Button
    Friend WithEvents BModificar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents DATitles As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As SqlClient.SqlCommand
    Friend WithEvents DAEditorial As SqlClient.SqlDataAdapter
    Friend WithEvents DsTitulos1 As DSTitulos
End Class
