Imports CWSFSC.Fighters

Public Class StressClassCal
    Private fighterTypes As ArrayList

    Private Sub StressClassCal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fighterTypes.Add(New FighterType("Super Fighter", 400))
        fighterTypes.Add(New FighterType("Advanced Tactical Fighter", 400))
        fighterTypes.Add(New FighterType("Long Range Recon", 300))
        fighterTypes.Add(New FighterType("Drone Fighter", 200))
        fighterTypes.Add(New FighterType("Scout", 150))
        fighterTypes.Add(New FighterType("Recon", 150))
        fighterTypes.Add(New FighterType("Interceptor", 120))
        fighterTypes.Add(New FighterType("Pursuit", 120))
        fighterTypes.Add(New FighterType("Heavy Drone", 120))
        fighterTypes.Add(New FighterType("Superiority", 110))
        fighterTypes.Add(New FighterType("Fleet Fighter", 110))
        fighterTypes.Add(New FighterType("Fleet Fighter", 110))
        fighterTypes.Add(New FighterType("Escort", 100))
        fighterTypes.Add(New FighterType("Light Defense", 100))
        fighterTypes.Add(New FighterType("Heavy Scout", 100))
        fighterTypes.Add(New FighterType("Strike", 90))
        fighterTypes.Add(New FighterType("Heavy Interceptor", 90))
        fighterTypes.Add(New FighterType("Support", 80))
        fighterTypes.Add(New FighterType("Defense", 80))
        fighterTypes.Add(New FighterType("Tropedo Bomber", 70))
        fighterTypes.Add(New FighterType("Light Bomber", 70))
        fighterTypes.Add(New FighterType("Light Attack", 70))
        fighterTypes.Add(New FighterType("Attack", 60))
        fighterTypes.Add(New FighterType("Heavy Support", 60))
        fighterTypes.Add(New FighterType("Heavy Defense", 60))
        fighterTypes.Add(New FighterType("Heavy Attack", 50))
        fighterTypes.Add(New FighterType("Medium Bomber", 50))
        fighterTypes.Add(New FighterType("Heavy Bomber", 40))
        fighterTypes.Add(New FighterType("Super Heavy Attack", 40))
        fighterTypes.Add(New FighterType("Super Heavy Bomber", 30))

        For Each t As FighterType In fighterTypes
            ListOfFighterTypesCheckBox.Items.Add(t.Name.ToString(), False)
        Next
    End Sub

    Private Sub SaveCtrlSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveCtrlSToolStripMenuItem.Click

    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub ListOfSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfSystemToolStripMenuItem.Click

    End Sub

    Private Sub ListOfFightersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfFightersToolStripMenuItem.Click

    End Sub

    Private Sub GetStressClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetStressClassToolStripMenuItem.Click

    End Sub
End Class
