﻿Public Class Form1

    ' Ouverture de la page Nouveau Contrat
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim FormNouveauContrat As New Form2
        FormNouveauContrat.Show()
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub

    Private Sub ConsulterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsulterToolStripMenuItem.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub

    Private Sub RésilierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RésilierToolStripMenuItem.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub
    ' Fermeture de l'application
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub
    ' Ouverture de la page Créer Client
    Private Sub CreerClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreerClientToolStripMenuItem.Click
        Dim FormCreerClient As New Form3
        FormCreerClient.Show()
    End Sub
    ' Envoie un MessageBox à l'utilisateur
    Private Sub DuJourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuJourToolStripMenuItem.Click
        MessageBox.Show("Les factures du jour sont envoyées à l'imprimante", "Impression", MessageBoxButtons.OK)
    End Sub

    Private Sub AutreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutreToolStripMenuItem.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub
    ' Envoie un MessageBox à l'utilisateur
    Private Sub TaxesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaxesToolStripMenuItem.Click
        Dim temps = Date.Now.ToString("yyyy/MM/dd")
        MessageBox.Show("TPS : 5%" & vbCrLf & "TVQ: 9.975%" & vbCrLf & "Total: 14.975%" & vbCrLf & "Date en vigueur: " & temps, "Projet en développement", MessageBoxButtons.OK)
    End Sub
    ' Ouverture de la page Transactions
    Private Sub DébitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DébitToolStripMenuItem.Click
        Dim FormTransactions As New Form4
        FormTransactions.Show()
    End Sub
    ' Ouverture de la page Gestion Employés
    Private Sub NouvelEmployéToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvelEmployéToolStripMenuItem.Click
        Dim FormNouvelEmploye As New Form5
        FormNouvelEmploye.Show()
    End Sub
    ' Envoie un MessageBox à l'utilisateur
    Private Sub ÀProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÀProposToolStripMenuItem.Click
        MessageBox.Show("Version 1.0", "Version de l'application", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub IndexeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndexeToolStripMenuItem.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub
    ' Ouverture de la page Nouveau Contrat
    Private Sub btnNouveauContrat_Click(sender As Object, e As EventArgs) Handles btnNouveauContrat.Click
        Dim FormNouveauContrat As New Form2
        FormNouveauContrat.Show()
    End Sub
    ' Ouverture de la page Créer Client
    Private Sub btnCreerClient_Click(sender As Object, e As EventArgs) Handles btnCreerClient.Click
        Dim FormCreerClient As New Form3
        FormCreerClient.Show()
    End Sub
    ' Ouverture de la page Gestion Employés
    Private Sub btnNouvelEmploye_Click(sender As Object, e As EventArgs) Handles btnNouvelEmploye.Click
        Dim FormNouvelEmploye As New Form5
        FormNouvelEmploye.Show()
    End Sub
    ' Ouverture de la page Transactions
    Private Sub btnRapportDeTransactions_Click(sender As Object, e As EventArgs) Handles btnRapportDeTransactions.Click
        Dim FormTransactions As New Form4
        FormTransactions.Show()
    End Sub
End Class
