Imports Microsoft.Win32
Imports System
Imports System.Diagnostics
Imports System.Windows.Forms

' 
' ---------------------------------------------------
' NOXIUS DEFENDER DISABLER
' ---------------------------------------------------
' Developed by rotomicora#0001
' ---------------------------------------------------
' https://discord.gg/noxius
' ---------------------------------------------------
' 

Namespace NoxiusDefenderDisabler
    Public Partial Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub





        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub label1_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub guna2ImageButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start("https://discord.gg/noxius")
        End Sub

        Private Sub guna2ImageButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start("https://github.com/franafp")
        End Sub

        Private Sub disable_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim key1 = Registry.LocalMachine.CreateSubKey("SOFTWARE\Policies\Microsoft\Windows Defender", True)
            key1.SetValue("DisableAntiSpyware", 1)
            If Equals(key1.GetValue("DisableAntiSpyware").ToString(), "0") Then
                MessageBox.Show("Failed to disable Windows Defender", "NoxiusDefenderDisabler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Equals(key1.GetValue("DisableAntiSpyware").ToString(), "1") Then
                MessageBox.Show("Windows Defender Disabled Sucessfully", "NoxiusDefenderDisabler", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            key1.Dispose()
        End Sub

        Private Sub enable_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim key1 = Registry.LocalMachine.CreateSubKey("SOFTWARE\Policies\Microsoft\Windows Defender", True)
            key1.SetValue("DisableAntiSpyware", 0)
            If key1.GetValue("DisableAntiSypware") IsNot Nothing AndAlso Equals(key1.GetValue("DisableAntiSypware").ToString(), "0") Then
                MessageBox.Show("Windows Defender Enabled Sucessfully", "NoxiusDefenderDisabler", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to enable Windows Defender", "NoxiusDefenderDisabler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            key1.Dispose()
        End Sub
    End Class
End Namespace
