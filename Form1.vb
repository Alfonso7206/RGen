Imports System.Text

Public Class Form1
    Private Sub BtnGen_Click(sender As Object, e As EventArgs) Handles BtnGen.Click
        RandomChars()
        Nato()
        Clipboard.SetText(TexGen.Text)
    End Sub

    Private Sub RandomChars()
        Dim validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!""#$%&*+-?@"
        Dim sb As New StringBuilder()
        Dim rd As New Random()
        For i As Integer = 1 To NumericUpDownCountChar.Value
            Dim idx As Integer = rd.Next(0, validchars.Length)
            Dim rdChar As Char = validchars(idx)
            sb.Append(rdChar)
        Next i
        Dim rdString = sb.ToString()
        TexGen.Text = rdString
    End Sub
    Public Sub Nato()
        Try
            Dim dDict As New Dictionary(Of Char, String)() From {
{"a"c, "Alfa"},
{"b"c, "Bravo"},
{"c"c, "Charlie"},
{"d"c, "Delta"},
{"e"c, "Echo"},
{"f"c, "Foxtrot"},
{"g"c, "Golf"},
{"h"c, "Hotel"},
{"i"c, "India"},
{"j"c, "Juliet"},
{"k"c, "Kilo"},
{"l"c, "Lima"},
{"m"c, "Mike"},
{"n"c, "November"},
{"o"c, "Oscar"},
{"p"c, "Papa"},
{"q"c, "Quebec"},
{"r"c, "Romeo"},
{"s"c, "Sierra"},
{"t"c, "Tango"},
{"u"c, "Uniform"},
{"v"c, "Victor"},
{"w"c, "Whiskey"},
{"x"c, "X-Ray"},
{"y"c, "Yankee"},
{"z"c, "Zulu"},
{""""c, "Double Quotation Mark"},
{"<"c, "Less-Than Sign"},
{">"c, "Greater-Than Sign"},
{"!"c, "Exclamination Mark"},
{"\"c, "Quatation Mark"},
{"#"c, "Number Sign"},
{"$"c, "Dollar Sign"},
{"%"c, "Percent Sign"},
{"&"c, "Ampersand"},
{"'"c, "Apostrophe"},
{"("c, "Left Parenthesis"},
{")"c, "Right Parenthesis"},
{"*"c, "Asterisk"},
{"+"c, "Plus Sign"},
{","c, "Comma"},
{"-"c, "Hyphen-Minus"},
{"."c, "Full Stop"},
{"/"c, "Solidus"},
{":"c, "Colon"},
{";"c, "Semicolon"},
{"="c, "Equals Sign"},
{"?"c, "Question Mark"},
{"@"c, "Commercial At"},
{"["c, "Left Square Bracket"},
{"]"c, "Left Square Bracket"},
{"^"c, "Circumflex Accent"},
{"_"c, "Low Line"},
{"`"c, "Grave Accent"},
{"{"c, "Left Curly Bracket"},
{"|"c, "Vertikal Line"},
{"}"c, "Right Curly Bracket"},
{"~"c, "Tilde"},
{"0"c, "Zero"},
{"1"c, "One"},
{"2"c, "Two"},
{"3"c, "Three"},
{"4"c, "Four"},
{"5"c, "Five"},
{"6"c, "Six"},
{"7"c, "Seven"},
{"8"c, "Eight"},
{"9"c, "Nine"}
}
            Dim result As String = String.Join("     " & vbNewLine, TexGen.Text.[Select](Function(x) dDict(Char.ToLower(x))))
            TextNato.Text = result
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "5-bit - Very Weak - Family"
        Panel1.Width = 50
        NumericUpDownCountChar.Value = 13
    End Sub

    Private Sub NumericUpDownCountChar_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownCountChar.ValueChanged
        RandomChars()
        Nato()
        If NumericUpDownCountChar.Value = 1 Then
            Panel1.Width = 50
            Panel1.BackColor = Color.DarkRed
            Label1.Text = "5-bit - Very Weak - Family"
        ElseIf NumericUpDownCountChar.Value = 2 Then
            Panel1.Width = 70
            Panel1.BackColor = Color.DarkRed
            Label1.Text = "11-bit - Very Weak - Family"
        ElseIf NumericUpDownCountChar.Value = 3 Then
            Panel1.Width = 90
            Panel1.BackColor = Color.Red
            Label1.Text = "18-bit - Very Weak - Family"
        ElseIf NumericUpDownCountChar.Value = 4 Then
            Panel1.Width = 110
            Panel1.BackColor = Color.Red
            Label1.Text = "26-bit - Very Weak - Family"
        ElseIf NumericUpDownCountChar.Value = 5 Then
            Panel1.Width = 130
            Panel1.BackColor = Color.Orange
            Label1.Text = "33-bit - Weak - Home User"
            ' Label1.ForeColor = Panel1.BackColor
        ElseIf NumericUpDownCountChar.Value = 6 Then
            Panel1.Width = 150
            Panel1.BackColor = Color.Orange
        ElseIf NumericUpDownCountChar.Value = 7 Then
            Panel1.Width = 170
            Panel1.BackColor = Color.Orange
        ElseIf NumericUpDownCountChar.Value = 8 Then
            Panel1.Width = 190
            Panel1.BackColor = Color.Yellow
            ' Label1.ForeColor = Panel1.BackColor
            Label1.Text = "52-bit - Weak - Company User"
        ElseIf NumericUpDownCountChar.Value = 9 Then
            Panel1.Width = 210
            Panel1.BackColor = Color.Yellow
            Label1.Text = "59-bit - Weak - Company User"
        ElseIf NumericUpDownCountChar.Value = 10 Then
            Panel1.Width = 230
            Panel1.BackColor = Color.YellowGreen
            Label1.Text = "66-bit - Reasonable - Government, Financial"
        ElseIf NumericUpDownCountChar.Value = 11 Then
            Panel1.Width = 250
            Panel1.BackColor = Color.YellowGreen
            Label1.Text = "72-bit - Reasonable - Government, Financial"
        ElseIf NumericUpDownCountChar.Value = 12 Then
            Panel1.Width = 270
            Panel1.BackColor = Color.YellowGreen
            Label1.Text = "79-bit - Reasonable - Government, Financial"
        ElseIf NumericUpDownCountChar.Value = 13 Then
            Panel1.Width = 290
            Panel1.BackColor = Color.Green
            Label1.Text = "85-bit - Strong - Military"
        ElseIf NumericUpDownCountChar.Value = 14 Then
            Panel1.Width = 310
            Panel1.BackColor = Color.Green
            Label1.Text = "92-bit - Strong - Military"
        ElseIf NumericUpDownCountChar.Value = 15 Then
            Panel1.Width = 330
            Panel1.BackColor = Color.Green
            Label1.Text = "98-bit - Strong - Military"
        ElseIf NumericUpDownCountChar.Value = 16 Then
            Panel1.Width = 350
            Panel1.BackColor = Color.DarkGreen
            Label1.Text = "105-bit - Strong - Military"
        ElseIf NumericUpDownCountChar.Value = 17 Then
            Panel1.Width = 370
            Panel1.BackColor = Color.DarkGreen
            Label1.Text = "111-bit - Strong - Military"
        ElseIf NumericUpDownCountChar.Value = 18 Then
            Panel1.Width = 390
            Panel1.BackColor = Color.DarkGreen
            Label1.Text = "118-bit - Strong - Military"
        ElseIf NumericUpDownCountChar.Value = 19 Then
            Panel1.Width = 410
            Panel1.BackColor = Color.DarkGreen
            Label1.Text = "125-bit - Strong - Military"
        ElseIf NumericUpDownCountChar.Value = 20 Then
            Panel1.Width = 430
            Panel1.BackColor = Color.Blue
            Label1.Text = "131-bit - Very Strong"
        End If
    End Sub

End Class
