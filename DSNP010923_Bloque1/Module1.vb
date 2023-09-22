Module Module1

    Sub Main(Args As String())

        Dim Edad As SByte

        Console.WriteLine("Ingrese la edad")
        Edad = Console.ReadLine()

        While (Edad < 0 Or Edad > 120)

            Console.WriteLine("Ingrese una edad Valida")
            Edad = Console.ReadLine()

        End While

        If (Edad > 18) Then
                Console.WriteLine("Eres mayor de edad")
            Else
                Console.WriteLine("Eres menor de edad")

        End If

        Console.ReadLine()
    End Sub

End Module
