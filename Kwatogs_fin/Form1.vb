Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListView1.View = View.Details
    End Sub

    Private Sub Lomi_But_Click(sender As Object, e As EventArgs) Handles Lomi_But.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = Lomi_Qty.Text
        meal = Lomi_Txt.Text


        If Lomi_Cat1.Checked Then
            price = Val(Lomi_Price1.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Lomi_Cat2.Checked Then
            price = Val(Lomi_Price2.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Lomi_Cat3.Checked Then
            price = Val(Lomi_Price3.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If

    End Sub

    Private Sub Canton_But_Click(sender As Object, e As EventArgs) Handles Canton_But.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = Canton_Qty.Text
        meal = Canton_Txt.Text


        If Canton_Cat1.Checked Then
            price = Val(Canton_Price1.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Canton_Cat2.Checked Then
            price = Val(Canton_Price2.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Canton_Cat3.Checked Then
            price = Val(Canton_Price3.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If


    End Sub

    Private Sub Chami_But_Click(sender As Object, e As EventArgs) Handles Chami_But.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = Chami_Qty.Text
        meal = Chami_Txt.Text


        If Chami_Cat1.Checked Then
            price = Val(Chami_Price1.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Chami_Cat2.Checked Then
            price = Val(Chami_Price2.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Chami_Cat3.Checked Then
            price = Val(Chami_Price3.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If


    End Sub

    Private Sub Bihon_But_Click(sender As Object, e As EventArgs) Handles Bihon_But.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = Bihon_Qty.Text
        meal = Bihon_Txt.Text


        If Bihon_Cat1.Checked Then
            price = Val(Bihon_Price1.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Bihon_Cat2.Checked Then
            price = Val(Bihon_Price2.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Bihon_Cat3.Checked Then
            price = Val(Bihon_Price3.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If

    End Sub

    Private Sub BlackG_But_Click(sender As Object, e As EventArgs) Handles BlackG_But.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = BlackG_Qty.Text
        meal = BlackG_Txt.Text


        If BlackG_Cat1.Checked Then
            price = Val(BlackG_Price1.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If BlackG_Cat2.Checked Then
            price = Val(BlackG_Price2.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If BlackG_Cat3.Checked Then
            price = Val(BlackG_Price3.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If

    End Sub

    Private Sub Yakisoba_But_Click(sender As Object, e As EventArgs) Handles Yakisoba_But.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = Yakisoba_Qty.Text
        meal = Yakisoba_Txt.Text


        If Yakisoba_Cat1.Checked Then
            price = Val(Yakisoba_Price1.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Yakisoba_Cat2.Checked Then
            price = Val(Yakisoba_Price2.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Yakisoba_Cat3.Checked Then
            price = Val(Yakisoba_Price3.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If

    End Sub

    Private Sub Sotanghon_But_Click(sender As Object, e As EventArgs) Handles Sotanghon_But.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = Sotanghon_Qty.Text
        meal = Sotanghon_Txt.Text


        If Sotanghon_Cat1.Checked Then
            price = Val(Sotanghon_Price1.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Sotanghon_Cat2.Checked Then
            price = Val(Sotanghon_Price2.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Sotanghon_Cat3.Checked Then
            price = Val(Sotanghon_Price3.Text) * qty
            Dim otherItems As String() = {meal, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If

    End Sub

    Private Sub Ksp_But_Click(sender As Object, e As EventArgs) Handles Ksp_But.Click
        Dim qty, price As Integer
        qty = Ksp_qty.Text

        If Ksp1.Checked Then
            price = Val(Ksp_Price1.Text) * qty
            Dim otherItems As String() = {"KSP1", price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Ksp2.Checked Then
            price = Val(Ksp_Price2.Text) * qty
            Dim otherItems As String() = {"KSP2", price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If

    End Sub

    Private Sub Rice_But_Click(sender As Object, e As EventArgs) Handles Rice_But.Click
        Dim qty, price As Integer
        qty = Rice_Qty.Text


        If Rice1.Checked Then
            price = Val(Rice_Price1.Text) * qty
            Dim otherItems As String() = {"RICE", price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Rice2.Checked Then
            price = Val(Rice_Price2.Text) * qty
            Dim otherItems As String() = {"FRIED RICE", price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If

    End Sub
    Private Sub tapsilog_but_Click(sender As Object, e As EventArgs) Handles tapsilog_but.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = tapsilog_qty.Text
        meal = tapsilog.Text

        price = Val(tapsilog_price.Text) * qty
        Dim otherItems As String() = {meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)

    End Sub

    Private Sub tocilog_but_Click(sender As Object, e As EventArgs) Handles tocilog_but.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = tocilog_qty.Text
        meal = tocilog.Text

        price = Val(tocilog_price.Text) * qty
        Dim otherItems As String() = {meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub chicksilog_but_Click(sender As Object, e As EventArgs) Handles chicksilog_but.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = chicksilog_qty.Text
        meal = chicksilog.Text

        price = Val(chicksilog_price.Text) * qty
        Dim otherItems As String() = {meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub
    Private Sub Proceed_but_Click(sender As Object, e As EventArgs) Handles Proceed_but.Click

        Dim Index As Integer
        Dim TotalValue As Double

        For Index = 1 To Me.ListView1.Items.Count - 1
            Dim X As Double = CDbl(Me.ListView1.Items.Item(Index).SubItems(2).Text)
            TotalValue = TotalValue + X
        Next

        Dim vats, tot_vat As Single

        vats = (TotalValue * 12) / 100
        tot_vat = TotalValue + vats

        sub_tot.Text = TotalValue
        tot_due.Text = tot_vat
        vat.Text = vats
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each item As ListViewItem In ListView1.SelectedItems
            ListView1.Items.Remove(item)
        Next
    End Sub


    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint
        If dc1.Checked Or dc2.Checked Then
            Label11.Visible = True
            num_discounted.Visible = True
        Else
            Label11.Visible = False
            num_discounted.Visible = False
        End If

        Dim disc, due As Single
        Dim no_discount As Integer

        due = Val(sub_tot.Text)
        no_discount = Val(num_discounted.Text)

        If dc1.Checked Or dc2.Checked Then
            disc = (((due * 0.2) - Val(vat.Text)) * no_discount)
        End If


        discounted_amount.Text = disc

    End Sub
    Private Sub num_discounted_MouseLeave(sender As Object, e As EventArgs) Handles num_discounted.MouseLeave
        Dim noD, noC As Integer
        noC = Val(num_customer.Text)
        noD = Val(num_discounted.Text)

        If noD > noC Then
            MsgBox("Invalid Number")
        End If
    End Sub

    Private Sub bayad_MouseLeave(sender As Object, e As EventArgs) Handles bayad.MouseLeave
        Dim due, binayad As Single
        due = Val(tot_due.Text)
        binayad = Val(bayad.Text)
        If due > binayad Then
            MsgBox("Invalid Amount")
        End If
        sukli.Text = (Val(bayad.Text) - Val(tot_due.Text)) + Val(discounted_amount.Text)
    End Sub

    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListView1.Items.Clear()
        ClearTextBox(Me)
    End Sub

    Private Sub Done_but_Click_1(sender As Object, e As EventArgs) Handles Done_but.Click
        MsgBox("Name:" & vbTab & vbTab & Val(Costumer_name.Text) & vbCrLf &
               "Subtotal:" & vbTab & vbTab & Val(sub_tot.Text) & vbCrLf &
               "VAT:" & vbTab & vbTab & Val(vat.Text) & vbCrLf &
               "Discounted:" & vbTab & Val(num_discounted.Text) & Space(3) & Val(discounted_amount.Text) & vbCrLf &
               "Total Due:" & vbTab & Val(tot_due.Text) & vbCrLf &
               "Paid:" & vbTab & vbTab & Val(bayad.Text) & vbCrLf &
               "Change:" & vbTab & vbTab & Val(sukli.Text))
        Me.Close()
    End Sub
End Class
