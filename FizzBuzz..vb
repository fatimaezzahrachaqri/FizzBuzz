Imports System
imports System.Text 

Public Class FizzBuzz

    Public Shared Sub FizzBuzz(ByRef param1 As Integer, ByRef param2 As Integer)
        
        Dim builder As New StringBuilder
        
        for compteur as Integer = 1 to 100
            if (compteur mod param1 = 0)
                builder.Append("Fizz")
            end if
            
            if (compteur mod param2 = 0)
                builder.Append("Buzz")
            end if
            
            if String.IsNullOrEmpty(builder.ToString)
                builder.Append(compteur)
            end if
            
            Console.WriteLine(builder.ToString)
            builder.Clear()
        next
    
    End Sub
    
    Public Shared Sub Main()
        FizzBuzz(3,5)
    End Sub
    
End Class