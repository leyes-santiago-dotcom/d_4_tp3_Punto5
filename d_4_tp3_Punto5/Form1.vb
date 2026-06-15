Public Class Form1
    '4. Realizar un algoritmo que permita cargar un vector de 10 elementos enteros. A partir del 
    'vector original generar un nuevo vector de 15 elementos, tal que el primer elemento del 
    'vector original pasa al primer elemento del segundo vector y el segundo elemento del 
    'original en el segundo elemento del vector nuevo y el tercer elemento del nuevo vector 
    'se forma con la suma de los 2 anteriores. Con los nuevos elementos se repite la secuencia. 
    'Mostrar en Pantalla los 2 vectores. 

    Dim Vector(10), NewVector(15), i, j As Integer

    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click

        For i = 1 To 10
            Vector(i) = 100 * Rnd()              'InputBox("Ingrese un numero entero")
        Next
        j = 1
        i = 1

        For k = 1 To 5
            NewVector(i) = Vector(j)
            NewVector(i + 1) = Vector(j + 1)
            NewVector(i + 2) = Vector(j) + Vector(j + 1)

            i = i + 3
            j = j + 2

        Next

        lstVector10.Items.Add("El Vector original es:")
        For j = 1 To 10
            lstVector10.Items.Add(Vector(j))
        Next

        lstVector15.Items.Add("El nuevo Vector es:")
        For i = 1 To 15
            lstVector15.Items.Add(NewVector(i))
        Next



    End Sub
End Class
