﻿Public Class clsWarshQuran
    Shared TimesNewRomanPSMT As New Dictionary(Of String, Integer()) From {
{"0", New Integer() {&H660}},
{"1", New Integer() {&H661}},
{"2", New Integer() {&H662}},
{"3", New Integer() {&H663}},
{"4", New Integer() {&H664}},
{"5", New Integer() {&H665}},
{"6", New Integer() {&H666}},
{"7", New Integer() {&H667}},
{"8", New Integer() {&H668}},
{"9", New Integer() {&H669}},
{"A", New Integer() {&H627}}}
    Shared ProfessionalNaskhSupplement1Variants As New Dictionary(Of String, Integer()) From {
{"", New Integer() {&HF22A}}}
    Shared ProfessionalNaskhSupplements4Kashidahs As New Dictionary(Of String, Integer()) From {
{"A", New Integer() {&H5D0, &HF242}},
{"b", New Integer() {&HF249}},
{"H", New Integer() {&HF25A}},
{"r", New Integer() {&HF269, &HF26A}},
{"s", New Integer() {&H6D, &H6F}},
{"$", New Integer() {&HF272, &HF274}},
{"S", New Integer() {&HF276}},
{"lm", New Integer() {&HF29D}},
{"E", New Integer() {&HF2A7, &HF2A9}},
{"f", New Integer() {&HF2AF, &HF2B1}},
{"l", New Integer() {&HF2BB}},
{"n", New Integer() {&HF2C3, &HF2C5}},
{"h", New Integer() {&HC7}},
{"w", New Integer() {&HF2CB, &H10F}},
{"y", New Integer() {&HF2CD}},
{"p", New Integer() {&HF2D2}},
{"", New Integer() {&H105, &H106, &H107, &H109, &H10F}}
} '109 + {105=b/n, 106=t/y, 107=v}, 10F + {105=f, 106=q}
    Shared Hamd2 As New Dictionary(Of String, Integer()) From {
    {"<", New Integer() {&H3, &H74}},
    {"i", New Integer() {&H7}},
    {"laA", New Integer() {&HD, &H1E, &H6C, &H6F, &H71}},
    {"l~uA", New Integer() {&H19}},
    {"li>a", New Integer() {&H1A}},
    {"luA", New Integer() {&H1D}},
    {"}i", New Integer() {&H22, &H23, &H79}},
    {"'", New Integer() {&H24, &HDB}},
    {"Yo", New Integer() {&H25}},
    {"}a", New Integer() {&H27, &H81, &H221E}},
    {"|", New Integer() {&H4E}},
    {"liA", New Integer() {&H50, &H7E}},
    {"&a", New Integer() {&H51}},
    {"w", New Integer() {&H53, &H55}},
    {"LFA", New Integer() {&H5A, &H5B, &H5C, &H5D}},
    {"LF[A", New Integer() {&H60, &H61}},
    {"L~F[A", New Integer() {&H62}},
    {"L~FA", New Integer() {&H65, &H67, &H68}},
    {"L~aA", New Integer() {&H6B}},
    {"w^", New Integer() {&H70}},
    {">a", New Integer() {&H75, &H77, &HDC, &HDD, &HDE}},
    {"<i", New Integer() {&H76, &H7F}},
    {"_", New Integer() {&H7B}},
    {"la", New Integer() {&H7D}},
    {"l", New Integer() {&H82}},
    {"`", New Integer() {&H97, &H98, &HA2}},
    {".", New Integer() {&H9B}},
    {"`^", New Integer() {&HA0}},
    {"-", New Integer() {&HA5}}
    }

    Shared MSHQuraan1 As New Dictionary(Of String, Integer()) From {
    {"L", New Integer() {&H2203}},
    {"Q", New Integer() {&H25}},
    {"C", New Integer() {&H26}},
    {"M", New Integer() {&H220B}},
    {"I", New Integer() {&H2217}},
    {"^", New Integer() {&H3A, &H3B}},
    {"]", New Integer() {&H3E}},
    {"", New Integer() {&H3A7, &H2206}},
    {"!", New Integer() {&H3A6}},
    {"`", New Integer() {&H397, &H3C5}},
    {"#", New Integer() {&H39A}},
    {"_", New Integer() {&H3A4}},
    {"i", New Integer() {&H3B3}},
    {"l", New Integer() {&HF081}},
    {"A", New Integer() {&H201A}},
    {"H", New Integer() {&H2014}},
    {"(", New Integer() {&H2248}},
    {")", New Integer() {&H2026}},
    {",", New Integer() {&H2287}},
    {"X", New Integer() {&H222B}}
    }
    Shared Arr1 As New Dictionary(Of String, Integer()) From {
{" ", New Integer() {&H20}},
{"llh", New Integer() {&H21}},
{"A", New Integer() {&H23, &H24, &H25}},
{">", New Integer() {&H26, &H27, &H28}},
{"<", New Integer() {&H29, &H2A}},
{"|", New Integer() {&H2C, &H2D}},
{"b", New Integer() {&H2F, &H30, &H31, &H32, &H33, &H35, &H36, &H37, &H39, &H3A, &H3B, &H3C, &H3D, &H3E}},
{"t", New Integer() {&H3F, &H40, &H41, &H42, &H43, &H45, &H46, &H47, &H48, &H49, &H4A, &H4B, &H4C, &H4D, &H4E}},
{"v", New Integer() {&H4F, &H52, &H53, &H56, &H57, &H59, &H5A, &H5B, &H5C, &H5D, &H5E}},
{"j", New Integer() {&H5F, &H60, &H62, &H64, &H65, &H66, &H67, &H6B, &H6C}},
{"H", New Integer() {&H6D, &H6E, &H6F, &H70, &H71, &H72, &H73, &H74, &H76, &H77, &H78, &H79}},
{"x", New Integer() {&H7A, &H7B, &H7D, &H7E, &HF081, &H201A, &H192, &H2020, &H2021, &H2C6}},
{"d", New Integer() {&H2030, &H160}},
{"*", New Integer() {&H2039, &H152}},
{"r", New Integer() {&HF08D, &HF08E, &HF08F, &HF090, &H2018, &H2019}},
{"z", New Integer() {&H201C, &H201D, &H2022, &H2013, &H2014}},
{"s", New Integer() {&H2122, &H203A, &H153, &HF09D, &HF09E, &HA0, &HA1, &HA3, &HA4, &HA6, &HA7, &HA8}},
{"$", New Integer() {&HA9, &HAB, &HAC, &H2212, &HB0, &HB1, &HB4, &HB5, &HB6, &HB7, &HB8}},
{"S", New Integer() {&HB9, &HBB, &HBC, &HBE, &HC0, &HC1, &HC2, &HC4, &HC7, &HC8, &HC9}},
{"D", New Integer() {&HCA, &HCC, &HCE, &HCF, &HD1, &HD2, &HD3, &HD5, &HD6, &HD8, &HD9, &HDA}},
{"T", New Integer() {&HDB, &HDC, &HDD, &HDE}},
{"Z", New Integer() {&HDF, &HE0, &HE1, &HE2}},
{"E", New Integer() {&HE3, &HE4, &HE5, &HE6, &HE7, &HE8, &HE9, &HEA, &HEB, &HEC, &HED}},
{"g", New Integer() {&HEE, &HEF, &HF0, &HF1, &HF3, &HF6, &HF0F7, &HF8}},
{"f", New Integer() {&HF9, &HF0FA, &HFB, &HF0FF}}
}
    Shared Arr2 As New Dictionary(Of String, Integer()) From {
    {" ", New Integer() {&H20}},
    {"f", New Integer() {&H2200, &H23, &H2203}},
    {"q", New Integer() {&H25, &H220B, &H29, &H2217, &H2B, &H2C, &H2212}},
    {"k", New Integer() {&H2E, &H30, &H31, &H32, &H33, &H34, &H35, &H36, &H37, &H38}},
    {"l", New Integer() {&H39, &H3A, &H3B, &H3C, &H3D, &H3E, &H3F, &H2245, &H391}},
    {"m", New Integer() {&H392, &H3A7, &H2206, &H395, &H393, &H397, &H399, &H3D1, &H39A, &H39B, &H39C, &H39D, &H39F, &H3A0, &H398}},
    {"n", New Integer() {&H3A1, &H3A3, &H3A4, &H3A5, &H3C2, &H2126, &H39E, &H3A8, &H396, &H2234, &H5D, &H22A5, &H5F, &H3B2, &H3C7, &H2205, &H239D, &HF0, &H239E, &H23A5, &H23A6, &H23AF}},
    {"h", New Integer() {&H3B4, &H3B5, &H3C6, &H3B3, &H3B7, &H3B9, &H3D5, &H3BA, &H3BB, &HB5, &H3BD}},
    {"p", New Integer() {&H3BF, &H3C0}},
    {"w", New Integer() {&H3B8, &H3C1}},
    {"&", New Integer() {&H3C3, &H3C4, &H3C5}},
    {"lA", New Integer() {&H3C9, &H3BE}},
    {"l>", New Integer() {&H3C8, &H7B, &H7C, &H7D, &H223C}},
    {"y", New Integer() {&H192, &H201E, &H2020, &H2021, &H2C6, &H2030, &H160, &H2039, &HF08D, &HF08E, &HF08F, &HF090, &H23A7, &H23AA, &H23AB}},
    {"Y", New Integer() {&HFF, &H2018, &H2019, &H201C, &H201D, &HA9, &HAC, &H23A9, &H2321}},
    {"}", New Integer() {&H2014, &H2DC, &H203A, &HF09D, &H2044, &H221E, &H2666}},
    {"#", New Integer() {&H2194, &H23AE}},
    {"X", New Integer() {&H2190, &H2033, &H2265, &HD7, &H221D}},
    {"`", New Integer() {&H2261, &H2248, &H2211}},
    {",", New Integer() {&H2026, &H23D0}},
    {".", New Integer() {&H23AF, &H21B5}},
    {"`#", New Integer() {&H2135}},
    {"`^", New Integer() {&H211C, &H2118}},
    {"_", New Integer() {&H2297}},
    {"=", New Integer() {&H2229}},
    {"", New Integer() {&H222A}},
    {"0", New Integer() {&H2283}},
    {"1", New Integer() {&H2287}},
    {"2", New Integer() {&H2284}},
    {"3", New Integer() {&H2282}},
    {"4", New Integer() {&H2286}},
    {"5", New Integer() {&H2208}},
    {"6", New Integer() {&H2209}},
    {"7", New Integer() {&H2220}},
    {"8", New Integer() {&H2207}},
    {"H", New Integer() {&H220F, &H21D4}},
    {"x", New Integer() {&H221A, &H21D0}},
    {"Y#", New Integer() {&H22C5}},
    {"j", New Integer() {&H2228}},
    {"S", New Integer() {&H21D1, &H21D2}},
    {"D", New Integer() {&H21D3}},
    {"(", New Integer() {&H2329}},
    {"9", New Integer() {&HAE}},
    {")", New Integer() {&HAE}},
    {"'", New Integer() {&H2122}},
    {"t", New Integer() {&H23A2, &H222B, &H23A0}},
    {"b", New Integer() {&H2320, &H23A4}},
    {"v", New Integer() {&H239F}}
    }
    Shared Arr3 As New Dictionary(Of String, Integer()) From {
            {"l", New Integer() {&H21, &H23, &H51}},
            {"d", New Integer() {&H24}},
            {"*", New Integer() {&H25}},
            {"h", New Integer() {&H26, &H53, &H2026, &H2030}},
            {"p", New Integer() {&H27}},
            {"t", New Integer() {&H29, &H56, &H6E}},
            {"y", New Integer() {&H2C, &H71}},
            {"Y", New Integer() {&H2E}},
            {"m", New Integer() {&H2F}},
            {"`", New Integer() {&H31, &H38, &H39}},
            {"n", New Integer() {&H47}},
            {"", New Integer() {&H52, &H5E, &H5F, &H201E, &H2020, &HF08E}},
            {"llh", New Integer() {&H54}},
            {"b", New Integer() {&H55}},
            {"v", New Integer() {&H57}},
            {"f", New Integer() {&H58, &H2019}},
            {"q", New Integer() {&H59}},
            {"s", New Integer() {&H5A, &H5B}},
            {"$", New Integer() {&H5C}},
            {"{lr~aHiymi", New Integer() {&H69}},
            {"{ll~`hi {lr~aHoma`ni", New Integer() {&H6A}},
            {"bisomi", New Integer() {&H6B}},
            {"k", New Integer() {&H6C, &H201A, &HF081}},
            {"E", New Integer() {&H192, &H201D}}
            }
    Shared Arr4 As New Dictionary(Of String, Integer()) From {
{" ", New Integer() {&H20}},
{"Q", New Integer() {&H22, &H33}},
{"C", New Integer() {&H23, &H34}},
{"^", New Integer() {&H24, &HFA, &HFB, &HFC, &HFD, &HFE, &HFF}},
{"K", New Integer() {&H25, &H26, &H35, &H37, &H38, &H39, &H3A, &H3B, &H3C, &H3E, &H3F, &H40, &H41, &H42, &H43}},
{"L", New Integer() {&H28}},
{"R", New Integer() {&H29}},
{"B", New Integer() {&H2A}},
{"F[", New Integer() {&H47, &H49, &H4A, &H4B, &H4C, &H4D, &H4E, &H4F, &H50, &H52}},
{"F", New Integer() {&H54, &H55, &H56, &H57, &H58, &H59, &H5A, &H5B, &H5C, &H5D, &HB2, &HB3, &HB4, &HB5, &HB6, &HB7, &HB8, &HB9, &HBA, &HBB}},
{"~", New Integer() {&H5F, &H61, &H62, &H63, &H64, &H65, &H67, &H68, &H69, &H6A, &H6B, &H6D, &H6E, &H6F, &H70}},
{"~F", New Integer() {&H72, &H74, &H75, &H76, &H77, &H78, &H79, &H7B, &H7C, &H7D, &H7E, &H201A, &H192, &H2026, &H2020, &H2021, &H2C6, &H2030}},
{"~u", New Integer() {&HF08E, &HF08F, &HF090, &H2018, &H2019, &H201C, &H201D, &H2022, &H2013, &H2014, &H2122, &H161, &H203A, &H153, &HF09D}},
{"~a", New Integer() {&HF09E, &HA0, &HA1, &HA2, &HA3, &HA4, &HA5, &HA6, &HA7, &HA8, &HA9, &HAA, &HAC, &H2212, &HAE, &HAF, &HB0}},
{"i", New Integer() {&HBD, &HBE, &HBF, &HC2, &HC3, &HC4, &HC5, &HC6, &HC7, &HC8, &HC9, &HCA, &HCB, &HCC, &HCD, &HCE, &HCF}},
{"N", New Integer() {&HD0, &HD1, &HD2, &HD3, &HD4, &HD6, &HD7, &HD8, &HEA, &HEB, &HEC, &HED, &HEE}},
{"u", New Integer() {&HD9, &HDA, &HDB, &HDC, &HDD, &HDE, &HDF, &HE0, &HE1, &HE2, &HE3, &HE4, &HE5, &HE6, &HE7, &HE8, &HE9}},
{"o", New Integer() {&HEF, &HF1, &HF2, &HF3, &HF4, &HF5, &HF6, &HF7, &HF8, &HF9}}
}
    'combine with alef
    Shared Arr5 As New Dictionary(Of String, Integer()) From {
    {" ", New Integer() {&H20}},
    {"^", New Integer() {&H21, &HF0AF}},
    {"`^", New Integer() {&H23}},
    {"{", New Integer() {&H24}},
    {"@", New Integer() {&H26, &H27, &H28}},
    {"[", New Integer() {&H2D, &H2E, &H2F}},
    {"a+", New Integer() {&H30}},
    {"`", New Integer() {&H32, &H33, &H34}},
    {"N[", New Integer() {&H36, &H37, &H38, &H39}},
    {"~u^", New Integer() {&H3A, &H3B, &H3C}},
    {"~N", New Integer() {&H3F, &H40, &H41}},
    {"~N[", New Integer() {&H42}},
    {"~F[", New Integer() {&H43}},
    {"oa", New Integer() {&H46}},
    {"~a^", New Integer() {&H48}},
    {"a^", New Integer() {&H49}},
    {"ia", New Integer() {&H4B, &H4C}},
    {"oi", New Integer() {&H4D}},
    {"""", New Integer() {&H4F}},
    {"iu", New Integer() {&H54}},
    {"aa", New Integer() {&H55, &H56}},
    {"~ia", New Integer() {&H58}},
    {"ai", New Integer() {&H5A}},
    {"~iu", New Integer() {&H5B}},
    {"ii", New Integer() {&H5C}},
    {"a{", New Integer() {&H5D}},
    {"~a{", New Integer() {&H5E}},
    {"au", New Integer() {&H5F}},
    {"~aa", New Integer() {&H60, &HA9}},
    {"~ii", New Integer() {&H62}},
    {"~au", New Integer() {&H63, &HAA}},
    {"aN", New Integer() {&H64}},
    {"i{", New Integer() {&H65}},
    {"ao", New Integer() {&H68}},
    {"a", New Integer() {&H31, &H6D, &H6E, &H6F, &H70, &H71, &H72, &H73, &H74, &H75, &H76, &H77, &H78, &H79, &H7A, &H7B, &H7C, &H7D, &H7E, &HF080, &HF08D, &H161, &H178}},
    {"~a", New Integer() {&H153, &HF09E}},
    {"I", New Integer() {&HA0}},
    {"O", New Integer() {&HA1}},
    {"M", New Integer() {&HA2}},
    {"K]", New Integer() {&HA3, &HA4, &HA5}},
    {"~ai", New Integer() {&HAB}},
    {"i~ai", New Integer() {&HAC}},
    {"~i~ai", New Integer() {&HB0}}
    }
    Shared Arr7 As New Dictionary(Of String, Integer()) From {
    {"a", New Integer() {&H31, &H76, &H79, &H7D, &HF08D}}
    } '&H31 is an imalee fatha
    Class CompareChar
        Implements IComparer(Of ArrayList)
        Public Function Compare(x As ArrayList, y As ArrayList) As Integer Implements IComparer(Of ArrayList).Compare
            'If x(3) = y(3) Then Return 0
            'Return If(x(3) > y(3), 1, -1)
            If CSng(x(1)) = CSng(y(1)) Then
                If CSng(x(0)) = CSng(y(0)) Then
                    Return 1
                End If
                Return If(CSng(x(0)) > CSng(y(0)), -1, 1)
            End If
            Return If(CSng(x(1)) > CSng(y(1)), -1, 1)
        End Function
    End Class
    Class TextExtractionStrategy
        Implements iTextSharp.text.pdf.parser.ITextExtractionStrategy
        Class Chunk
            Public Str As String
            Public FontName As String
            Public Start As iTextSharp.text.pdf.parser.Vector
            Public Finish As iTextSharp.text.pdf.parser.Vector
            Public Sub New(NewStr As String, NewFontName As String, NewStart As iTextSharp.text.pdf.parser.Vector, NewFinish As iTextSharp.text.pdf.parser.Vector)
                Str = NewStr
                FontName = NewFontName
                Start = NewStart
                Finish = NewFinish
            End Sub
        End Class
        Public Chunks As New Generic.List(Of Chunk)
        Dim Chapter As Integer = 0
        Public Sub BeginTextBlock() Implements iTextSharp.text.pdf.parser.IRenderListener.BeginTextBlock

        End Sub

        Public Sub EndTextBlock() Implements iTextSharp.text.pdf.parser.IRenderListener.EndTextBlock

        End Sub

        Public Sub RenderImage(renderInfo As iTextSharp.text.pdf.parser.ImageRenderInfo) Implements iTextSharp.text.pdf.parser.IRenderListener.RenderImage

        End Sub

        Public Sub RenderText(renderInfo As iTextSharp.text.pdf.parser.TextRenderInfo) Implements iTextSharp.text.pdf.parser.IRenderListener.RenderText
            For Count As Integer = 0 To renderInfo.GetCharacterRenderInfos.Count - 1
                Dim Segment As iTextSharp.text.pdf.parser.LineSegment = renderInfo.GetCharacterRenderInfos(Count).GetBaseline()
                Chunks.Add(New Chunk(renderInfo.GetCharacterRenderInfos(Count).GetText(), renderInfo.GetFont().PostscriptFontName, Segment.GetStartPoint(), Segment.GetEndPoint()))
            Next
            'Hamd2 must be read out of content stream directly as the encoding is non-standard
        End Sub

        Public Function GetResultantText() As String Implements iTextSharp.text.pdf.parser.ITextExtractionStrategy.GetResultantText
            Dim Str As String = String.Empty
            Dim QStr As String = String.Empty
            Chunks.Sort(Function(First As Chunk, Second As Chunk)
                            If First.Start.Item(iTextSharp.text.pdf.parser.Vector.I2) = Second.Start.Item(iTextSharp.text.pdf.parser.Vector.I2) Or Math.Abs(First.Start.Item(iTextSharp.text.pdf.parser.Vector.I2) - Second.Start.Item(iTextSharp.text.pdf.parser.Vector.I2)) < 0.003 Then
                                If First.Start.Item(iTextSharp.text.pdf.parser.Vector.I1) = Second.Start.Item(iTextSharp.text.pdf.parser.Vector.I1) Or Math.Abs(First.Start.Item(iTextSharp.text.pdf.parser.Vector.I1) - Second.Start.Item(iTextSharp.text.pdf.parser.Vector.I1)) < 0.003 Then
                                    Return If(Second.FontName = "BAMCGA+HQPB4" Or Second.FontName = "BAMCHB+HQPB5" Or Second.FontName = "BAMDFB+HQPB7", -1, 1)
                                End If
                                Return If(First.Start.Item(iTextSharp.text.pdf.parser.Vector.I1) > Second.Start.Item(iTextSharp.text.pdf.parser.Vector.I1), -1, 1)
                            End If
                            Return If(First.Start.Item(iTextSharp.text.pdf.parser.Vector.I2) > Second.Start.Item(iTextSharp.text.pdf.parser.Vector.I2), -1, 1)

                            'Dim Vec1 As iTextSharp.text.pdf.parser.Vector = First.Finish.Subtract(First.Start)
                            'If Vec1.Length = 0 Then
                            '    Vec1 = New iTextSharp.text.pdf.parser.Vector(1, 0, 0)
                            'Else
                            '    Vec1 = Vec1.Normalize()
                            'End If
                            'Dim Vec2 As iTextSharp.text.pdf.parser.Vector = Second.Finish.Subtract(Second.Start)
                            'If Vec2.Length = 0 Then
                            '    Vec2 = New iTextSharp.text.pdf.parser.Vector(1, 0, 0)
                            'Else
                            '    Vec2 = Vec1.Normalize()
                            'End If
                            'Dim Mag1 As Integer = CInt(Math.Atan2(Vec1(iTextSharp.text.pdf.parser.Vector.I2), Vec1(iTextSharp.text.pdf.parser.Vector.I1)) * 1000)
                            'Dim Mag2 As Integer = CInt(Math.Atan2(Vec2(iTextSharp.text.pdf.parser.Vector.I2), Vec2(iTextSharp.text.pdf.parser.Vector.I1)) * 1000)
                            'If Mag1 = Mag2 Then
                            '    Dim DistPerp1 As Integer = CInt(First.Start.Subtract(New iTextSharp.text.pdf.parser.Vector(0, 0, 1)).Cross(Vec1).Item(iTextSharp.text.pdf.parser.Vector.I3))
                            '    Dim DistPerp2 As Integer = CInt(Second.Start.Subtract(New iTextSharp.text.pdf.parser.Vector(0, 0, 1)).Cross(Vec2).Item(iTextSharp.text.pdf.parser.Vector.I3))
                            '    If DistPerp1 = DistPerp2 Then
                            '        Return If(Vec1.Dot(First.Start) < Vec2.Dot(Second.Start), -1, 1)
                            '    Else
                            '        Return If(DistPerp1 < DistPerp2, -1, 1)
                            '    End If
                            'Else
                            '    Return If(Mag1 < Mag2, -1, 1)
                            'End If
                        End Function)
            For Count As Integer = 0 To Chunks.Count - 1
                Dim CurDict As Dictionary(Of String, Integer()) = Nothing
                If Chunks(Count).FontName = "BAMCIC+HQPB1" Then
                    CurDict = Arr1
                ElseIf Chunks(Count).FontName = "BAMCGB+HQPB2" Then
                    CurDict = Arr2
                ElseIf Chunks(Count).FontName = "BAMCJD+HQPB3" Then
                    CurDict = Arr3
                ElseIf Chunks(Count).FontName = "BAMCGA+HQPB4" Then
                    CurDict = Arr4
                ElseIf Chunks(Count).FontName = "BAMCHB+HQPB5" Then
                    CurDict = Arr5
                ElseIf Chunks(Count).FontName = "BAMDFB+HQPB7" Then
                    CurDict = Arr7
                    'ElseIf Chunks(Count).FontName = "BAMBNO+DecoType-ProfessionalNaskhSupplement4Kashidahs" Then
                    '    CurDict = ProfessionalNaskhSupplements4Kashidahs
                    'ElseIf Chunks(Count).FontName = "BAMCPB+DecoType-ProfessionalNaskhSupplement1Variants" Then
                    '    CurDict = ProfessionalNaskhSupplement1Variants
                ElseIf Chunks(Count).FontName = "BAMCAO+TimesNewRomanPSMT" Then
                    CurDict = TimesNewRomanPSMT
                ElseIf Chunks(Count).FontName = "BAMDAC+Hamd2" Then
                    CurDict = Hamd2
                ElseIf Chunks(Count).FontName = "BAPFCA+MSH-Quraan1" Then
                    CurDict = MSHQuraan1
                ElseIf Chunks(Count).FontName = "BAMCBO+TimesNewRomanPSMT" Then
                    If Str.Length <> 0 AndAlso Str.Chars(Str.Length - 1) <> " "c Then Str += " "
                    'ElseIf Chunks(Count).FontName = "TraditionalArabic" Then
                End If
                If Not CurDict Is Nothing Then
                    For Each KeyValue As Collections.Generic.KeyValuePair(Of String, Integer()) In CurDict
                        Dim Match As Integer = Array.IndexOf(KeyValue.Value, System.Text.Encoding.Unicode.GetBytes(Chunks(Count).Str)(0) + 256 * System.Text.Encoding.Unicode.GetBytes(Chunks(Count).Str)(1))
                        If Match <> -1 Then
                            'redundant value corrections
                            If KeyValue.Value(Match) = &H23AF And KeyValue.Key = "n" And Str.Length > 1 AndAlso Str.Chars(Str.Length - 1) = "i" AndAlso Str.Chars(Str.Length - 2) = "h" Then Continue For
                            If KeyValue.Value(Match) = &HAE And KeyValue.Key = "9" And Str.Length = 0 Then Continue For
                            If Str.Length <> 0 AndAlso Str.Chars(Str.Length - 1) = "A" AndAlso KeyValue.Key = "{" Then
                                Str = Str.Remove(Str.Length - 1) + KeyValue.Key
                            ElseIf KeyValue.Key = "i~ai" Or KeyValue.Key = "~i~ai" Then
                                'If Str.Length > 2 AndAlso Str.Substring(Str.Length - 3) = "llh" Then
                                Str = Str.Insert(Str.Length - 2, KeyValue.Key.Chars(0))
                                If KeyValue.Key.Chars(0) = "~" Then
                                    Str = Str.Insert(Str.Length - 2, KeyValue.Key.Chars(1))
                                End If
                                Str = Str.Insert(Str.Length - 1, KeyValue.Key.Chars(If(KeyValue.Key.Chars(0) = "~", 2, 1)) + KeyValue.Key.Chars(If(KeyValue.Key.Chars(0) = "~", 3, 2)))
                                Str += KeyValue.Key.Chars(If(KeyValue.Key.Chars(0) = "~", 4, 3))
                                'End If
                            ElseIf KeyValue.Key <> String.Empty AndAlso KeyValue.Key.Length >= If(KeyValue.Key.Chars(0) = "~", 3, 2) AndAlso ("aiuo^".IndexOf(KeyValue.Key.Chars(1)) <> -1 And "aiuo^".IndexOf(KeyValue.Key.Chars(If(KeyValue.Key.Chars(0) = "~", 2, 0))) <> -1) Then
                                '"oa", "ia", "oi", "iu", "aa", "~ia", "ai", "~iu", "ii", "au", "~aa", "~ii", "~au", "ao", "~ai"
                                'If Str.Length > 2 AndAlso Str.Substring(Str.Length - 3) = "llh" Then
                                Str = Str.Insert(Str.Length - 1, KeyValue.Key.Chars(0))
                                If KeyValue.Key.Chars(0) = "~" Then
                                    Str = Str.Insert(Str.Length - 1, KeyValue.Key.Chars(1))
                                End If
                                Str += KeyValue.Key.Chars(If(KeyValue.Key.Chars(0) = "~", 2, 1))
                                'End If
                            ElseIf KeyValue.Key = "~a" Then
                                If Str.Length <> 0 AndAlso Str.Chars(Str.Length - 1) = "A" Then
                                    Str = Str.Insert(Str.Length - 1, KeyValue.Key)
                                Else
                                    Str += KeyValue.Key
                                End If
                            ElseIf KeyValue.Key = "a" Then
                                If Str.Length <> 0 AndAlso Str.Chars(Str.Length - 1) = "A" Then
                                    Str = Str.Insert(Str.Length - 1, KeyValue.Key)
                                ElseIf Str.Length <> 0 AndAlso Str.Chars(Str.Length - 1) = "a" Then
                                Else
                                    Str += KeyValue.Key
                                End If
                            ElseIf KeyValue.Key = "i" Then
                                If Str.Length <> 0 AndAlso Str.Chars(Str.Length - 1) = "i" Then
                                Else
                                    Str += KeyValue.Key
                                End If
                            ElseIf KeyValue.Key = "~" Then
                                If Str.Length <> 0 AndAlso Str.Chars(Str.Length - 1) = "A" Then
                                    Str = Str.Insert(Str.Length - 1, KeyValue.Key)
                                ElseIf Str.Length <> 0 AndAlso (Str.Chars(Str.Length - 1) = "a" Or Str.Chars(Str.Length - 1) = "i") Then
                                    Str = Str.Insert(Str.Length - 1, KeyValue.Key)
                                ElseIf Str.Length <> 0 AndAlso Str.Chars(Str.Length - 1) = "~" Then
                                Else
                                    Str += KeyValue.Key
                                End If
                            ElseIf KeyValue.Key = "=" Then
                                If Str.Substring(Str.LastIndexOf(" "c) + 1) = "1" Then
                                    If Chapter <> 0 Then QStr += "  </sura>" + vbCrLf
                                    Chapter += 1
                                    Dim Idx As Integer = Str.IndexOf(" (")
                                    If Idx = -1 Then Idx = Str.IndexOf(" madaniy~ap")
                                    If Idx = -1 Then Idx = Str.IndexOf(" ma_k~iy~apN")
                                    QStr += "  <sura index=""" + CStr(Chapter) + """ name=""" + IslamMetadata.HTTPCoding.XmlEncode(Str.Substring(0, Idx).Replace("suwrapu ", String.Empty).Replace(") ", String.Empty)) + """>" + vbCrLf
                                End If
                                Dim Index As Integer = Str.IndexOf("bisomi {ll~ahi {lr~aHoma`ni {lr~aHiymi ")
                                If Index = -1 Then
                                    Index = Str.IndexOf("bisomi{ll~`hi {lr~aHoma`ni{lr~aHiymi ")
                                    If Index <> -1 Then Index += "bisomi{ll~`hi {lr~aHoma`ni{lr~aHiymi ".Length
                                Else
                                    Index += "bisomi {ll~ahi {lr~aHoma`ni {lr~aHiymi ".Length
                                End If
                                If Str.Substring(Str.LastIndexOf(" "c) + 1) = "1" AndAlso Index <> -1 Then
                                    QStr += "    <aya index=""" + StrReverse(Str.Substring(Str.LastIndexOf(" "c) + 1)) + """ text=""" + IslamMetadata.HTTPCoding.XmlEncode(Str.Substring(Index, Str.LastIndexOf(" "c) - Index)) + """ " + "bismillah=""bisomi {ll~ahi {lr~aHoma`ni {lr~aHiymi""/>" + vbCrLf
                                Else
                                    QStr += "    <aya index=""" + StrReverse(Str.Substring(Str.LastIndexOf(" "c) + 1)) + """ text=""" + IslamMetadata.HTTPCoding.XmlEncode(Str.Substring(0, Str.LastIndexOf(" "c))) + """ />" + vbCrLf
                                End If
                                Str = String.Empty
                            Else
                                Str += KeyValue.Key
                            End If
                            Exit For
                        End If
                    Next
                End If
            Next
            Return QStr
        End Function
    End Class
    Class ContOpText
        Implements iTextSharp.text.pdf.parser.IContentOperator
        Dim WaitForString As Boolean = False
        Dim Res As iTextSharp.text.pdf.PdfDictionary
        Public Sub Invoke(processor As iTextSharp.text.pdf.parser.PdfContentStreamProcessor, oper As iTextSharp.text.pdf.PdfLiteral, operands As List(Of iTextSharp.text.pdf.PdfObject)) Implements iTextSharp.text.pdf.parser.IContentOperator.Invoke
            If operands.Count > 0 AndAlso operands(0).IsName Then
                If CType(CType(Res.Get(New iTextSharp.text.pdf.PdfName("Font")), iTextSharp.text.pdf.PdfDictionary).Get(CType(operands(0), iTextSharp.text.pdf.PdfName)), iTextSharp.text.pdf.PdfDictionary).Get(New iTextSharp.text.pdf.PdfName("BaseFont")).ToString() = "BAMDAC+Hamd2" Then
                    WaitForString = True
                Else
                    WaitForString = False
                End If
            End If
            For Count As Integer = 0 To operands.Count - 1
                '"/Resources/Font/<name>/BaseFont"
                If operands(Count).IsString() Then
                    Debug.Print(CType(operands(Count), iTextSharp.text.pdf.PdfString).ToUnicodeString())
                End If
            Next
        End Sub
    End Class
    Class RenderListen
        Implements iTextSharp.text.pdf.parser.IRenderListener

        Public Sub BeginTextBlock() Implements iTextSharp.text.pdf.parser.IRenderListener.BeginTextBlock

        End Sub

        Public Sub EndTextBlock() Implements iTextSharp.text.pdf.parser.IRenderListener.EndTextBlock

        End Sub

        Public Sub RenderImage(renderInfo As iTextSharp.text.pdf.parser.ImageRenderInfo) Implements iTextSharp.text.pdf.parser.IRenderListener.RenderImage

        End Sub

        Public Sub RenderText(renderInfo As iTextSharp.text.pdf.parser.TextRenderInfo) Implements iTextSharp.text.pdf.parser.IRenderListener.RenderText

        End Sub
    End Class
    Shared Function ParseQuran() As String
        Dim Reader As New iTextSharp.text.pdf.PdfReader("..\..\..\IslamMetadata\warsh.pdf")
        Dim Str As String = "<?xml version=""1.0"" encoding=""utf-8""?>" + vbCrLf + "<quran>" + vbCrLf
        Dim Strat As New TextExtractionStrategy
        For Cnt As Integer = 0 To Reader.NumberOfPages - 1
            Dim parse As New iTextSharp.text.pdf.parser.PdfContentStreamProcessor(New RenderListen)
            parse.RegisterContentOperator("Tf", New ContOpText)
            parse.RegisterContentOperator("Tj", New ContOpText)
            parse.ProcessContent(Reader.GetPageContent(Cnt + 1), Reader.GetPageResources(Cnt + 1))
            Strat.Chunks.Clear()
            Str += iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(Reader, Cnt + 1, Strat)
        Next
        Str += "  </sura>" + vbCrLf + "</quran>" + vbCrLf
        IO.File.WriteAllText("warsh.txt", Str)
    End Function
End Class
