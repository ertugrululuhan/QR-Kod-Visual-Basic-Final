Imports QRCoder
Public Class Form1
    Private Sub btnOlustur_Click(sender As Object, e As EventArgs) Handles btnOlustur.Click
        Dim olustur As New QRCodeGenerator
        Dim qr = olustur.CreateQrCode(TextBox1.Text, QRCodeGenerator.ECCLevel.Q)
        Dim kod As New QRCode(qr)
        PictureBox1.Image = kod.GetGraphic(10)

    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim yolSec As New SaveFileDialog
        yolSec.Filter = "JPG Dosyası | *.jpg"
        yolSec.Title = "QR Kod Kaydet"
        yolSec.FileName = "qr-code-SelmaYazılım"
        If yolSec.ShowDialog = DialogResult.OK Then
            PictureBox1.Image.Save(yolSec.FileName)
        End If
    End Sub
End Class
