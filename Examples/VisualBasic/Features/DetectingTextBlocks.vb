'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.OCR. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.OCR
Imports System

Namespace Aspose.OCR.Examples.Features
    Public Class DetectingTextBlocks
        Public Shared Sub Main()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.OCR.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            'Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            'Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

            'Remove non-textual blocks
            ocrEngine.Config.RemoveNonText = True

            'Run recognition process
            If ocrEngine.Process() Then
                'Display text block locations
                For Each part As IRecognizedPartInfo In ocrEngine.Text.PartsInfo
                    Console.WriteLine(part.Box)
                Next part
            End If
        End Sub
    End Class
End Namespace