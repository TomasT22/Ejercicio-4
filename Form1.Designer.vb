<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dtvMatriz = New System.Windows.Forms.DataGridView()
        Me.cmdEjecutar = New System.Windows.Forms.Button()
        Me.lblVector = New System.Windows.Forms.Label()
        Me.dtvVector = New System.Windows.Forms.DataGridView()
        CType(Me.dtvMatriz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtvVector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtvMatriz
        '
        Me.dtvMatriz.AllowUserToAddRows = False
        Me.dtvMatriz.AllowUserToDeleteRows = False
        Me.dtvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvMatriz.ColumnHeadersVisible = False
        Me.dtvMatriz.Location = New System.Drawing.Point(36, 12)
        Me.dtvMatriz.Name = "dtvMatriz"
        Me.dtvMatriz.ReadOnly = True
        Me.dtvMatriz.RowHeadersVisible = False
        Me.dtvMatriz.Size = New System.Drawing.Size(328, 230)
        Me.dtvMatriz.TabIndex = 0
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(384, 12)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEjecutar.TabIndex = 1
        Me.cmdEjecutar.Text = "Ejecutar"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        '
        'lblVector
        '
        Me.lblVector.AutoSize = True
        Me.lblVector.Location = New System.Drawing.Point(33, 274)
        Me.lblVector.Name = "lblVector"
        Me.lblVector.Size = New System.Drawing.Size(39, 13)
        Me.lblVector.TabIndex = 2
        Me.lblVector.Text = "Label1"
        '
        'dtvVector
        '
        Me.dtvVector.AllowUserToAddRows = False
        Me.dtvVector.AllowUserToDeleteRows = False
        Me.dtvVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvVector.ColumnHeadersVisible = False
        Me.dtvVector.Location = New System.Drawing.Point(36, 299)
        Me.dtvVector.Name = "dtvVector"
        Me.dtvVector.ReadOnly = True
        Me.dtvVector.RowHeadersVisible = False
        Me.dtvVector.Size = New System.Drawing.Size(404, 26)
        Me.dtvVector.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtvVector)
        Me.Controls.Add(Me.lblVector)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Controls.Add(Me.dtvMatriz)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dtvMatriz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtvVector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtvMatriz As DataGridView
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents lblVector As Label
    Friend WithEvents dtvVector As DataGridView
End Class
