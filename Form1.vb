Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtvMatriz.ColumnCount = 8
        dtvMatriz.Rows.Add(10)
        dtvVector.ColumnCount = 10
        dtvVector.Rows.Add()
        For i = 0 To 9
            dtvVector.Columns(i).Width = 40
        Next
        For i = 0 To 7
            dtvMatriz.Columns(i).Width = 40
        Next
    End Sub

    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim matriz(10, 8) As Integer
        Dim vector(10) As Integer
        For f = 1 To 10
            For c = 1 To 8
                matriz(f - 1, c - 1) = Rnd() * 100
            Next
        Next
        For f = 0 To 9
            For c = 0 To 7
                dtvMatriz.Item(c, f).Value = matriz(f, c)
            Next
        Next
        For f = 0 To 9
            vector(f) = matriz(f, 1)
            For c = 1 To 7
                If matriz(f, c) < vector(f) Then
                    vector(f) = matriz(f, c)
                End If
            Next
        Next
        lblVector.Text = "El vector formado con los minimos de cada fila es:"
        For f = 0 To 9
            dtvVector.Item(f, 0).Value = vector(f)
        Next
    End Sub
End Class
