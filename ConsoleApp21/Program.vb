Imports System

' Define Student class
Class Student
    Public Name As String
    Public RollNumber As Integer
    Public Grade As Char

    ' Constructor
    Public Sub New(name As String, rollNumber As Integer, grade As Char)
        Me.Name = name
        Me.RollNumber = rollNumber
        Me.Grade = grade
    End Sub

    ' Display student details
    Public Sub DisplayDetails()
        Console.WriteLine("Name: " & Name)
        Console.WriteLine("Roll Number: " & RollNumber)
        Console.WriteLine("Grade: " & Grade)
        Console.WriteLine()
    End Sub
End Class

Module StudentManagementSystem
    Sub Main()
        ' Define an array to hold student objects
        Dim students(10) As Student
        Dim choice As Integer = 0
        Dim count As Integer = 0

        ' Loop for menu
        While choice <> 4
            Console.WriteLine("1. Add Student")
            Console.WriteLine("2. Display All Students")
            Console.WriteLine("3. Search Student")
            Console.WriteLine("4. Exit")
            Console.Write("Enter your choice: ")
            choice = Convert.ToInt32(Console.ReadLine())

            Select Case choice
                Case 1
                    ' Add Student
                    If count < 10 Then
                        Console.Write("Enter Student Name: ")
                        Dim name As String = Console.ReadLine()
                        Console.Write("Enter Roll Number: ")
                        Dim rollNumber As Integer = Convert.ToInt32(Console.ReadLine())
                        Console.Write("Enter Grade: ")
                        Dim grade As Char = Convert.ToChar(Console.ReadLine())

                        ' Create new Student object and add to array
                        students(count) = New Student(name, rollNumber, grade)
                        count += 1
                    Else
                        Console.WriteLine("Maximum limit reached!")
                    End If

                Case 2
                    ' Display All Students
                    If count > 0 Then
                        For i As Integer = 0 To count - 1
                            students(i).DisplayDetails()
                        Next
                    Else
                        Console.WriteLine("No students added yet!")
                    End If

                Case 3
                    ' Search Student
                    If count > 0 Then
                        Console.Write("Enter Roll Number to search: ")
                        Dim rollToSearch As Integer = Convert.ToInt32(Console.ReadLine())
                        Dim found As Boolean = False

                        ' Search for student
                        For i As Integer = 0 To count - 1
                            If students(i).RollNumber = rollToSearch Then
                                Console.WriteLine("Student found:")
                                students(i).DisplayDetails()
                                found = True
                                Exit For
                            End If
                        Next

                        If Not found Then
                            Console.WriteLine("Student not found!")
                        End If
                    Else
                        Console.WriteLine("No students added yet!")
                    End If

                Case 4
                    ' Exit
                    Console.WriteLine("Exiting...")
                    Environment.Exit(0)

                Case Else
                    Console.WriteLine("Invalid choice! Please enter again.")

            End Select
        End While
    End Sub
End Module

