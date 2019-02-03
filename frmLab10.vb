Public Class frmLab10
    Dim decArrSalse(4, 2) As Decimal
    Dim strEmpName(4) As String
    Dim intIndexMax As Integer
    Dim decMaxSale, decSumSaleA, decSumSaleB, decSumSaleC, decSum As Decimal

    Private Sub frmLab10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 0 To 5
            cboIndex.Items.Add(i + 1)
        Next
        cboIndex.SelectedIndex = 0
    End Sub
    Private Sub displaySaleData()
        Dim decSumSaleA = 0
        Dim decSumSaleB = 0
        Dim decSumSaleC = 0
        Dim i As Integer
        lstData.Items.Clear()

        For i = 0 To strEmpName.Length - 1

            lstData.Items.Add(strEmpName(i) & "," & decArrSalse(i, 0) & "," & decArrSalse(i, 1) & "," & decArrSalse(i, 2))

            decSumSaleA += decArrSalse(i, 0)
            decSumSaleB += decArrSalse(i, 1)
            decSumSaleC += decArrSalse(i, 2)
            decSum = decArrSalse(i, 0) + decArrSalse(i, 1) + decArrSalse(i, 2)


            If decMaxSale < decSum Then
                decMaxSale = decSum
                intIndexMax = i

            End If
        Next
        lblSumA.Text = decSumSaleA
        lblSumB.Text = decSumSaleB
        lblSumC.Text = decSumSaleC
        lblMaxSaleName.Text = strEmpName(intIndexMax)
        lblMaxSaleAmount.Text = decMaxSale
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtSaleName.Text = "" Then
            MessageBox.Show("ข้อมูลไม่สมบูรณ์", "Erer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSaleName.Focus()
            Exit Sub
        ElseIf txtSaleA.Text = "" Then
            MessageBox.Show("กรุณาใส่ตัวเลข", "Erer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSaleA.Focus()
            Exit Sub
        ElseIf txtSaleB.Text = "" Then
            MessageBox.Show("กรุณาใส่ตัวเลข", "Erer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSaleB.Focus()
            Exit Sub
        ElseIf txtSaleC.Text = "" Then
            MessageBox.Show("กรุณาใส่ตัวเลข", "Erer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSaleC.Focus()
        Else
            strEmpName(cboIndex.SelectedIndex) = txtSaleName.Text
            decArrSalse(cboIndex.SelectedIndex, 0) = Val(txtSaleA.Text)
            decArrSalse(cboIndex.SelectedIndex, 1) = Val(txtSaleB.Text)
            decArrSalse(cboIndex.SelectedIndex, 2) = Val(txtSaleC.Text)


            Call displaySaleData()








        End If
    End Sub
End Class