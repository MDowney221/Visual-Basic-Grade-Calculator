Module Module1

    Sub Main()

        'Declare Variables
        Dim firstName As String
        Dim lastName As String
        Dim studentPoints As Decimal = 0
        Dim totalPercentage As Decimal = 0
        Dim finalGrade As String = 0
        Const TOTALPOINTS = 10000

        'Gets the Students info
        Console.WriteLine("This program will collect information on a student and calculate a student's grade (In %)")
        Console.Write("Please enter the first name of the student: ")
        firstName = Console.ReadLine
        Console.Write("Please enter the last name of the student: ")
        lastName = Console.ReadLine
        Console.Write("Please enter the student's total points: ")
        studentPoints = Console.ReadLine

        totalPercentage = studentPoints / TOTALPOINTS

        'Calculates Letter Grade based on totalPercentage
        If (totalPercentage >= 0.9) And (totalPercentage <= 1.0) Then
            finalGrade = "A"
        ElseIf (totalPercentage >= 0.8) And (totalPercentage < 0.9) Then
            finalGrade = "B"
        ElseIf (totalPercentage >= 0.7) And (totalPercentage < 0.8) Then
            finalGrade = "C"
        ElseIf (totalPercentage >= 0.6) And (totalPercentage < 0.7) Then
            finalGrade = "D"
        ElseIf (totalPercentage >= 0) And (totalPercentage < 0.6) Then
            finalGrade = "F"
        Else
            finalGrade = "This is not a valid grade"
        End If

        If (totalPercentage >= 0) And (totalPercentage <= 1.0) Then
            Console.WriteLine(firstName & " " & lastName & " " & "earned " & studentPoints & " points, which is " & totalPercentage.ToString("P") & " and a letter grade of " & finalGrade)
            Console.WriteLine("All information for this student has been calculated. Please run the program again to calculate another student's grade. Thank you.")
        Else
            Console.WriteLine("This is not a valid grade.")
        End If
        Console.ReadLine()

    End Sub

End Module
