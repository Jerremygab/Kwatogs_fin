Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Form1


    Private Sub Lomi_But_Click(sender As Object, e As EventArgs) Handles Lomi_But.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = Lomi_Qty.Text
        meal = Lomi_Txt.Text


        If Lomi_Cat1.Checked Then
            price = Val(Lomi_Price1.Text) * Val(Lomi_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Lomi_Cat1.Text & Space(1) & meal & vbTab & vbTab & price)
        End If
        If Lomi_Cat2.Checked Then
            price = Val(Lomi_Price2.Text) * Val(Lomi_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Lomi_Cat2.Text & Space(1) & meal & vbTab & vbTab & price)
        End If
        If Lomi_Cat3.Checked Then
            price = Val(Lomi_Price3.Text) * Val(Lomi_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Lomi_Cat3.Text & Space(1) & meal & vbTab & vbTab & price)
        End If

        Price_Listbox.Items.Add(price)
    End Sub

    Private Sub Canton_But_Click(sender As Object, e As EventArgs) Handles Canton_But.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = Canton_Qty.Text
        meal = Canton_Txt.Text


        If Canton_Cat1.Checked Then
            price = Val(Canton_Price1.Text) * Val(Canton_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Canton_Cat1.Text & Space(1) & meal & vbTab & vbTab & price)
        End If
        If Canton_Cat2.Checked Then
            price = Val(Canton_Price2.Text) * Val(Canton_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Canton_Cat2.Text & Space(1) & vbTab & vbTab & price)
        End If
        If Canton_Cat3.Checked Then
            price = Val(Canton_Price3.Text) * Val(Canton_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Canton_Cat3.Text & Space(1) & vbTab & vbTab & price)
        End If

        Price_Listbox.Items.Add(price)

    End Sub

    Private Sub Chami_But_Click(sender As Object, e As EventArgs) Handles Chami_But.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = Chami_Qty.Text
        meal = Chami_Txt.Text


        If Chami_Cat1.Checked Then
            price = Val(Chami_Price1.Text) * Val(Chami_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Lomi_Cat1.Text & Space(1) & meal & vbTab & vbTab & price)
        End If
        If Chami_Cat2.Checked Then
            price = Val(Chami_Price2.Text) * Val(Chami_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Chami_Cat2.Text & Space(1) & vbTab & vbTab & price)
        End If
        If Chami_Cat3.Checked Then
            price = Val(Chami_Price3.Text) * Val(Chami_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Chami_Cat3.Text & Space(1) & vbTab & vbTab & price)
        End If

        Price_Listbox.Items.Add(price)

    End Sub

    Private Sub Bihon_But_Click(sender As Object, e As EventArgs) Handles Bihon_But.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = Bihon_Qty.Text
        meal = Bihon_Txt.Text


        If Bihon_Cat1.Checked Then
            price = Val(Bihon_Price1.Text) * Val(Bihon_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Bihon_Cat1.Text & Space(1) & meal & vbTab & vbTab & price)
        End If
        If Bihon_Cat2.Checked Then
            price = Val(Bihon_Price2.Text) * Val(Bihon_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Bihon_Cat2.Text & Space(1) & vbTab & vbTab & price)
        End If
        If Bihon_Cat3.Checked Then
            price = Val(Bihon_Price3.Text) * Val(Bihon_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Bihon_Cat3.Text & Space(1) & vbTab & vbTab & price)
        End If

        Price_Listbox.Items.Add(price)
    End Sub

    Private Sub BlackG_But_Click(sender As Object, e As EventArgs) Handles BlackG_But.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = BlackG_Qty.Text
        meal = BlackG_Txt.Text


        If BlackG_Cat1.Checked Then
            price = Val(BlackG_Price1.Text) * Val(BlackG_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & BlackG_Cat1.Text & Space(1) & meal & vbTab & price)
        End If
        If BlackG_Cat2.Checked Then
            price = Val(BlackG_Price2.Text) * Val(BlackG_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & BlackG_Cat2.Text & Space(1) & vbTab & price)
        End If
        If BlackG_Cat3.Checked Then
            price = Val(BlackG_Price3.Text) * Val(BlackG_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & BlackG_Cat3.Text & Space(1) & vbTab & vbTab & price)
        End If

        Price_Listbox.Items.Add(price)
    End Sub

    Private Sub Yakisoba_But_Click(sender As Object, e As EventArgs) Handles Yakisoba_But.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = Yakisoba_Qty.Text
        meal = Yakisoba_Txt.Text


        If Yakisoba_Cat1.Checked Then
            price = Val(Yakisoba_Price1.Text) * Val(Yakisoba_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Yakisoba_Cat1.Text & Space(1) & meal & vbTab & price)
        End If
        If Yakisoba_Cat2.Checked Then
            price = Val(Yakisoba_Price2.Text) * Val(Yakisoba_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Yakisoba_Cat2.Text & Space(1) & vbTab & price)
        End If
        If Yakisoba_Cat3.Checked Then
            price = Val(Yakisoba_Price3.Text) * Val(Yakisoba_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Yakisoba_Cat3.Text & Space(1) & vbTab & vbTab & price)
        End If

        Price_Listbox.Items.Add(price)
    End Sub

    Private Sub Sotanghon_But_Click(sender As Object, e As EventArgs) Handles Sotanghon_But.Click
        Dim qty, price As Integer
        Dim meal As String
        qty = Sotanghon_Qty.Text
        meal = Sotanghon_Txt.Text


        If Sotanghon_Cat1.Checked Then
            price = Val(Sotanghon_Price1.Text) * Val(Sotanghon_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Sotanghon_Cat1.Text & Space(1) & meal & vbTab & price)
        End If
        If Sotanghon_Cat2.Checked Then
            price = Val(Sotanghon_Price2.Text) * Val(Sotanghon_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Sotanghon_Cat2.Text & Space(1) & vbTab & price)
        End If
        If Sotanghon_Cat3.Checked Then
            price = Val(Sotanghon_Price3.Text) * Val(Sotanghon_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Sotanghon_Cat3.Text & Space(1) & vbTab & price)
        End If

        Price_Listbox.Items.Add(price)
    End Sub

    Private Sub Ksp_But_Click(sender As Object, e As EventArgs) Handles Ksp_But.Click
        Dim qty, price As Integer
        qty = Ksp_qty.Text


        If Ksp1.Checked Then
            price = Val(Ksp_Price1.Text) * Val(Ksp_qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Ksp1.Text & Space(1) & vbTab & vbTab & vbTab & price)
        End If
        If Ksp2.Checked Then
            price = Val(Ksp_Price2.Text) * Val(Ksp_qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Ksp2.Text & Space(1) & vbTab & vbTab & vbTab & price)
        End If

        Price_Listbox.Items.Add(price)
    End Sub

    Private Sub Rice_But_Click(sender As Object, e As EventArgs) Handles Rice_But.Click
        Dim qty, price As Integer
        qty = Rice_Qty.Text


        If Rice1.Checked Then
            price = Val(Rice_Price1.Text) * Val(Rice_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Rice1.Text & Space(1) & vbTab & vbTab & price)
        End If
        If Rice2.Checked Then
            price = Val(Rice_Price2.Text) * Val(Rice_Qty.Text)
            Orders_Listbox.Items.Add(qty & vbTab & Rice2.Text & Space(1) & vbTab & vbTab & price)
        End If

        Price_Listbox.Items.Add(price)
    End Sub

    Private Sub Proceed_but_Click(sender As Object, e As EventArgs) Handles Proceed_but.Click
        Dim sum As Double
        For x As Integer = 0 To Price_Listbox.Items.Count - 1
            sum += CDbl(Price_Listbox.Items(x))
        Next

        TotalAmount.Text = sum.ToString
    End Sub

    Private Sub Paid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Paid.KeyPress
        Dim dc As Single
        dc = (Val(Paid.Text) - Val(TotalAmount.Text)) + Val(Discount.Text)
        Change.Text = dc
    End Sub

    Private Sub Done_But_Click(sender As Object, e As EventArgs) Handles Done_But.Click
        MsgBox("Thank you " & name_txt.Text & "! Please Come Back Again!")
        Me.Close()
    End Sub

    Private Sub Again_But_Click(sender As Object, e As EventArgs) Handles Again_But.Click
        Orders_Listbox.Items.Clear()
        Dim a As Control

        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint
        Dim dc As Single

        If Dc1.Checked Then
            dc = TotalAmount.Text * 0.08
        End If
        If Dc2.Checked Then
            dc = TotalAmount.Text * 0.08
        End If

        Discount.Text = dc

    End Sub

    Private Sub Change_TextChanged(sender As Object, e As EventArgs) Handles Change.TextChanged

    End Sub
End Class
