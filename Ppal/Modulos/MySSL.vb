Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Net
Imports System.Security.Cryptography.X509Certificates

Public Class TrustAllCertificatePolicy
    Implements System.Net.ICertificatePolicy

    Public Sub TrustAllCertificatePolicy()

    End Sub

    Public Function CheckValidationResult(ByVal sp As ServicePoint, ByVal cert As X509Certificate, ByVal req As WebRequest, ByVal problem As Integer) As Boolean Implements ICertificatePolicy.CheckValidationResult

        Return True
    End Function


End Class