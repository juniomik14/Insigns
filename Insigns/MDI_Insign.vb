Imports System.Windows.Forms

Public Class MDI_Insign

    Dim esPare As Boolean
    Dim idPare As String
    Dim idMenu As String
    Dim dts As DataSet
    Dim item As bcMenuItem.SdSMenuItem


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub MDI_Insign_Load(sender As Object, e As EventArgs) Handles Me.Load


        SdSMenuStrip.Items.Clear()
        Dim db As ConnectionClass.ClassDB

        db = New ConnectionClass.ClassDB()



        dts = db.portaTaula("Menu")




        For Each dr As DataRow In dts.Tables(0).Rows
            Dim idmenu As Integer = 0
            item = New bcMenuItem.SdSMenuItem()

            item.Text = dr("textmenu")
            If dr("Pare") = False Then
                item.Classe = dr("DLL")

                item.Form = dr("Form")
            End If

            item.EsPare = dr("Pare")
            'item.EsPare = _esPare;

            If dr("Pare") = True Then
                idmenu = dr("idMenu")
                SdSMenuStrip.Items.Add(item)
                AddFills(idmenu)
            End If


        Next
        '  

    End Sub


    Private Sub AddFills(idMenu As String)


        For Each dr As DataRow In dts.Tables(0).Rows
            If dr("Pare") = False Then
                Dim fill As String = dr("textmenu")
                idPare = dr("idpare")
                If idPare = idMenu Then

                    item.DropDownItems.Add(fill)
                End If

            End If


        Next





    End Sub



    Private m_ChildFormNumber As Integer



End Class
