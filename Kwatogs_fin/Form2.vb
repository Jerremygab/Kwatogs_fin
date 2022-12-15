Imports System.Reflection.Emit
Imports System.Security.Claims

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Lomi_reg_Click(sender As Object, e As EventArgs) Handles Lomi_reg.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Lomi_qty.Text
        meal = Lomi.Text
        pr = Lomi_reg.Text

        price = pr * qty
        Dim otherItems As String() = {"Regular " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Lomi_spe_Click(sender As Object, e As EventArgs) Handles Lomi_spe.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Lomi_qty.Text
        meal = Lomi.Text
        pr = Lomi_spe.Text

        price = pr * qty
        Dim otherItems As String() = {"Special " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Lomi_ove_Click(sender As Object, e As EventArgs) Handles Lomi_ove.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Lomi_qty.Text
        meal = Lomi.Text
        pr = Lomi_ove.Text

        price = pr * qty
        Dim otherItems As String() = {"Overload " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Canton_spe_Click(sender As Object, e As EventArgs) Handles Canton_spe.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Canton_qty.Text
        meal = Canton.Text
        pr = Canton_spe.Text

        price = pr * qty
        Dim otherItems As String() = {"Special " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Canton_chic_Click(sender As Object, e As EventArgs) Handles Canton_chic.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Canton_qty.Text
        meal = Canton.Text
        pr = Canton_chic.Text

        price = pr * qty
        Dim otherItems As String() = {"Chicken " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Canton_sis_Click(sender As Object, e As EventArgs) Handles Canton_sis.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Canton_qty.Text
        meal = Canton.Text
        pr = Canton_sis.Text

        price = pr * qty
        Dim otherItems As String() = {"Sisig " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Chami_spe_Click(sender As Object, e As EventArgs) Handles Chami_spe.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Chami_qty.Text
        meal = Chami.Text
        pr = Chami_spe.Text

        price = pr * qty
        Dim otherItems As String() = {"Regular " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Chami_chic_Click(sender As Object, e As EventArgs) Handles Chami_chic.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Chami_qty.Text
        meal = Chami.Text
        pr = Chami_chic.Text

        price = pr * qty
        Dim otherItems As String() = {"Chicken " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Chami_sis_Click(sender As Object, e As EventArgs) Handles Chami_sis.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Chami_qty.Text
        meal = Chami.Text
        pr = Chami_sis.Text

        price = pr * qty
        Dim otherItems As String() = {"Sisig " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Bihon_spe_Click(sender As Object, e As EventArgs) Handles Bihon_spe.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Bihon_qty.Text
        meal = Bihon.Text
        pr = Bihon_spe.Text

        price = pr * qty
        Dim otherItems As String() = {"Special " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Bihon_chic_Click(sender As Object, e As EventArgs) Handles Bihon_chic.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Bihon_qty.Text
        meal = Bihon.Text
        pr = Bihon_chic.Text

        price = pr * qty
        Dim otherItems As String() = {"Chicken " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Bihon_sis_Click(sender As Object, e As EventArgs) Handles Bihon_sis.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Bihon_qty.Text
        meal = Bihon.Text
        pr = Bihon_sis.Text

        price = pr * qty
        Dim otherItems As String() = {"Sisig " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Yakisoba_spe_Click(sender As Object, e As EventArgs) Handles Yakisoba_spe.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Yakisoba_qty.Text
        meal = Yakisoba.Text
        pr = Yakisoba_spe.Text

        price = pr * qty
        Dim otherItems As String() = {"Special " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Yakisoba_chic_Click(sender As Object, e As EventArgs) Handles Yakisoba_chic.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Yakisoba_qty.Text
        meal = Yakisoba.Text
        pr = Yakisoba_chic.Text

        price = pr * qty
        Dim otherItems As String() = {"Chicken " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Yakisoba_sis_Click(sender As Object, e As EventArgs) Handles Yakisoba_sis.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Yakisoba_qty.Text
        meal = Yakisoba.Text
        pr = Yakisoba_sis.Text

        price = pr * qty
        Dim otherItems As String() = {"Sisig " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Black_spe_Click(sender As Object, e As EventArgs) Handles Black_spe.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Black_qty.Text
        meal = Black.Text
        pr = Black_spe.Text

        price = pr * qty
        Dim otherItems As String() = {"Special " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Black_chic_Click(sender As Object, e As EventArgs) Handles Black_chic.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Black_qty.Text
        meal = Black.Text
        pr = Black_chic.Text

        price = pr * qty
        Dim otherItems As String() = {"Chicken " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Black_sis_Click(sender As Object, e As EventArgs) Handles Black_sis.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Black_qty.Text
        meal = Black.Text
        pr = Black_sis.Text

        price = pr * qty
        Dim otherItems As String() = {"Sisig " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Fried_spe_Click(sender As Object, e As EventArgs) Handles Fried_spe.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Fried_qty.Text
        meal = Fried.Text
        pr = Fried_spe.Text

        price = pr * qty
        Dim otherItems As String() = {"Special " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Sotanghon_spe_Click(sender As Object, e As EventArgs) Handles Sotanghon_spe.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Sotanghon_qty.Text
        meal = Sotanghon.Text
        pr = Sotanghon_spe.Text

        price = pr * qty
        Dim otherItems As String() = {"Special " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Sotanghon_chic_Click(sender As Object, e As EventArgs) Handles Sotanghon_chic.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Sotanghon_qty.Text
        meal = Sotanghon.Text
        pr = Sotanghon_chic.Text

        price = pr * qty
        Dim otherItems As String() = {"Chicken " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Sotanghon_sis_Click(sender As Object, e As EventArgs) Handles Sotanghon_sis.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Sotanghon_qty.Text
        meal = Sotanghon.Text
        pr = Sotanghon_sis.Text

        price = pr * qty
        Dim otherItems As String() = {"Sisig " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Tapsi_spe_Click(sender As Object, e As EventArgs) Handles Tapsi_spe.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Tapsi_qty.Text
        meal = Tapsi.Text
        pr = Tapsi_spe.Text

        price = pr * qty
        Dim otherItems As String() = {"Special " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Toci_spe_Click(sender As Object, e As EventArgs) Handles Toci_spe.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Toci_qty.Text
        meal = Toci.Text
        pr = Toci_spe.Text

        price = pr * qty
        Dim otherItems As String() = {"Special " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Chick_spe_Click(sender As Object, e As EventArgs) Handles Chick_spe.Click
        Dim qty, price, pr As Integer
        Dim meal As String
        qty = Chick_qty.Text
        meal = Chick.Text
        pr = Chick_spe.Text

        price = pr * qty
        Dim otherItems As String() = {"Special " & meal, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub
    Private Sub Ksp_1_Click(sender As Object, e As EventArgs) Handles Ksp_1.Click
        Dim qty, price, pr As Integer
        qty = Ksp_qty.Text
        pr = Ksp_1.Text

        price = pr * qty
        Dim otherItems As String() = {"Special " & "KSP 1", price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Ksp_2_Click(sender As Object, e As EventArgs) Handles Ksp_2.Click
        Dim qty, price, pr As Integer
        qty = Ksp_qty.Text
        pr = Ksp_2.Text

        price = pr * qty
        Dim otherItems As String() = {"Special " & "KSP 2", price}
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
    Private Sub Remove_but_Click(sender As Object, e As EventArgs) Handles Remove_but.Click
        For Each item As ListViewItem In ListView1.SelectedItems
            ListView1.Items.Remove(item)
        Next
    End Sub



    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint




    End Sub
    Private Sub num_discounted_MouseLeave(sender As Object, e As EventArgs) Handles num_discounted.MouseLeave
        Dim noD, noC As Integer
        noC = Val(num_customer.Text)
        noD = Val(num_discounted.Text)

        If noD > noC Then
            MsgBox("Invalid Number")
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

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class