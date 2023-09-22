Module Module1

    Sub Main(Args As String())

        Dim cadena1 As String.
       
       



        Console.WriteLine("Ingrese la edad")

        cadena1 = Console.ReadLine()
        If (cadena1 < 0 Or cadena1 > 100) Then
            Console.WriteLine()

        End If
        Console.WriteLine("Hoy si va a funcionar")
        Console.ReadLine()
    End Sub

End Module
