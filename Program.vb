Imports System
Imports System.Windows.Forms

'' 

'---------------------------------------------------
'            NOXIUS DEFENDER DISABLER
'---------------------------------------------------
'           Developed by rotomicora#0001
'---------------------------------------------------
'            https://discord.gg/noxius
'---------------------------------------------------

Namespace NoxiusDefenderDisabler
    Friend Module Program

        <STAThread>
        Private Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
