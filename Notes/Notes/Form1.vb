Public Class form1
    Dim nsm As String = "P:\Job File\"
    Dim nc As String = "P:\Job file - NORTHCLAD\"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each prog As String In _
                FileIO.FileSystem.GetFiles("C:\Workstation\")


            ListBox_Startup.Items.Add(prog.Substring(15))
        Next

        'System.Windows.Forms.FormStartPosition.Manual()


        ' Dim ofile As System.IO.File
        Dim oread As System.IO.StreamReader
        oread = IO.File.OpenText("P:\Northshore Time Sheet\Tools\Standard.txt")
        While oread.Peek <> -1
            ListBox_Standard.Items.Add(oread.ReadLine())
        End While
        oread.Close()
        Dim t As Date = TimeOfDay
        Label_Time.Text = t
        Timer1.Enabled = True
        Timer2.Enabled = True


        'P:\CADD\Drafting\Standards
        For Each draftingstandards As String In _
                FileIO.FileSystem.GetFiles("P:\CADD\Drafting\Standards", FileIO.SearchOption.SearchTopLevelOnly, "*.dwg")


            ListBoxDrawingsStandards.Items.Add(draftingstandards.Substring(27))
        Next

        ListBox_NSMjobfile.Items.Clear()


        For Each i As String In _
                My.Computer.FileSystem.GetDirectories("P:\Job File")


            ListBox_NSMjobfile.Items.Add(i.Substring(12))
        Next


        ListBox_NCjobfile.Items.Clear()
        For Each i As String In _
            My.Computer.FileSystem.GetDirectories("P:\job file - northclad\")

            'add all the job folder names to the list
            ListBox_NCjobfile.Items.Add(i.Substring(24))
        Next



    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Brandan.Click
        Dim oread As System.IO.StreamReader
        oread = IO.File.OpenText("P:\Northshore Time Sheet\Tools\Brandan.txt")
        While oread.Peek <> -1
            ListBox_UsedNotes.Items.Add(oread.ReadLine())
        End While
        oread.Close()
        Label_Name.Text = "Brandan"
        ListBox_UsedNotes.Sorted = True
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Corey.Click
        Dim oread As System.IO.StreamReader
        oread = IO.File.OpenText("P:\Northshore Time Sheet\Tools\Corey.txt")
        While oread.Peek <> -1
            ListBox_UsedNotes.Items.Add(oread.ReadLine())
        End While
        oread.Close()
        Label_Name.Text = "Corey"
        ListBox_UsedNotes.Sorted = True
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Label_Name.Text = "Brandan" Then
            Dim owrite As System.IO.StreamWriter
            owrite = IO.File.CreateText("P:\Northshore Time Sheet\Tools\Brandan.txt")
            For Each i In ListBox_UsedNotes.Items()
                owrite.WriteLine(i)
            Next
            owrite.Close()
        ElseIf Label_Name.Text = "Corey" Then
            Dim owrite As System.IO.StreamWriter
            owrite = IO.File.CreateText("P:\Northshore Time Sheet\Tools\Corey.txt")
            For Each i In ListBox_UsedNotes.Items()
                owrite.WriteLine(i)
            Next
            owrite.Close()
        Else
            MessageBox.Show("Who Are you?")
        End If
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox_UsedNotes.Items.Clear()
        ListBox_UsedNotes.Sorted = True
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox_UsedNotes.Items.Remove(ListBox_UsedNotes.SelectedItem)
        ListBox_UsedNotes.Sorted = True
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("I Dont Do Anything...")
        Form2.Show()
    End Sub

    Private Sub ListBox_Standard_MouseDoubleClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox_Standard.MouseDoubleClick
        Clipboard.SetText(ListBox_Standard.SelectedItem)
        ListBox_UsedNotes.Items.Add(ListBox_Standard.SelectedItem)
        ListBox_UsedNotes.Sorted = True
    End Sub

    Private Sub Button_AddNote_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AddNote.Click
        ListBox_UsedNotes.Items.Add(TextBox_Note.Text)
        Clipboard.SetText(TextBox_Note.Text)
        ListBox_UsedNotes.Sorted = True
    End Sub

    Private Sub ListBox_UsedNotes_MouseDoubleClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox_UsedNotes.MouseDoubleClick
        Clipboard.SetText(ListBox_UsedNotes.SelectedItem)
    End Sub

    Private Sub Label4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Process.Start("C:\Program Files\Autodesk\AutoCAD 2013\acad.exe")
    End Sub

    Private Sub Label5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Process.Start("C:\Program Files\Autodesk\Revit 2013\Program\Revit.exe")
    End Sub

    Private Sub Label6_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Process.Start("C:\Users\brandan.NSSM\AppData\Local\Google\Chrome\Application\chrome.exe")
    End Sub

    Private Sub Label7_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Process.Start("C:\Program Files\Internet Explorer\iexplore.exe")
    End Sub

    Private Sub Label8_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Process.Start("C:\Users\brandan.NSSM\Dropbox\")
    End Sub

    Private Sub Label9_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Process.Start("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Accessories\Calculator")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim t As Date = TimeOfDay
        Label_Time.Text = t
        'Dim h As Double = Label10.Text
        'Label10.Text = h - 0.00027777777777777778


    End Sub

    Private Sub ListBox_NSMjobfile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox_NSMjobfile.SelectedIndexChanged
        ListBox_NSMcaddshops.Items.Clear()
        ListBox_NSMautocad.Items.Clear()
        ListBox_NSMworkorder.Items.Clear()
        ListBox_NSMplans.Items.Clear()



        Try

            Dim jf As String = nsm & ListBox_NSMjobfile.SelectedItem
            Dim jfint As Integer = jf.Length

            Dim i As String = jf & "\Submittals\CADD Shops\"
            Dim iint As Integer = i.Length

            Dim k As String = jf & "\Workorders\"
            Dim kint As Integer = k.Length

            Dim m As String = jf & "\Plans\"
            Dim mint As Integer = m.Length

            For Each j As String In _
                My.Computer.FileSystem.GetDirectories(i)
                ListBox_NSMcaddshops.Items.Add(j.Substring(iint))
            Next

            For Each l As String In _
                My.Computer.FileSystem.GetFiles(k)
                ListBox_NSMworkorder.Items.Add(l.Substring(kint))
            Next

            For Each n As String In _
                My.Computer.FileSystem.GetFiles(m)
                ListBox_NSMplans.Items.Add(n.Substring(mint))
            Next
        Catch
        End Try
    End Sub

    Private Sub ListBox_NSMjobfile_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox_NSMjobfile.MouseDoubleClick
        Dim i As String = nsm & ListBox_NSMjobf   . *    �      A           5  �      .ctor      �  A   �      $*WorkSpace  2 $@PX:xml=http://www.w3.org/XML/1998/namespace    * $@PX:xmlns=http://www.w3.org/2000/xmlns/  $@P:System.Xml.Linq   $@P:System    $@P:System.Collections   " $@P:System.Collections.Generic    $@P:System.Linq   $@P:Microsoft.VisualBasic     $@P:System.Windows.Forms  $@P:System.Diagnostics    $@P:System.Data   $@P:System.Drawing   
 $@PX:=    $WorkSpace       2 *    d      1           7  �      Dispose     �  `  1   �      $@100663349  "      )         VB$CG$t_bool$S0     > *    <      �3          8  	      InitializeComponent     h  8  �3  	      $@100663349  "      *         VB$t_struct$N0  "     *         VB$t_struct$S1  "     *         VB$t_struct$N2  "     *         VB$t_struct$S3  "     *         VB$t_struct$N4  "     *         VB$t_struct$N5  "     *         VB$t_struct$S6  "     *         VB$t_array$S0   "     *         VB$t_struct$N7  "  	   *         VB$t_struct$S8      2 *    �      :          �  �<      Form1_Load  @  �  :  �<      $*WorkSpace  2 $@PX:xml=http://www.w3.org/XML/1998/namespace    * $@PX:xmlns=http://www.w3.org/2000/xmlns/  $@P:System.Xml.Linq   $@P:System    $@P:System.Collections   " $@P:System.Collections.Generic    $@P:System.Linq   $@P:Microsoft.VisualBasic     $@P:System.Windows.Forms  $@P:System.Diagnostics    $@P:System.Data   $@P:System.Drawing   
 $@PX:=    $WorkSpace         �          oread        �          t        �         VB$t_ref$L0 "     �         VB$t_array$S0        �         VB$t_ref$L1   	   �         VB$t_ref$L2   
   �         VB$t_ref$L3 "     �         VB$CG$t_bool$S0  t  H     �<          �          prog       t  �     �=     &     �          draftingstandards      t  �     
>          �          i      t  �     �>          �          i         : *    �      ]           �  �>      Button1_Click_1        �  ]   �>      $@100663493        �          oread   "     �         VB$CG$t_bool$S0     : *    T	      ]           �  *?      Button3_Click_1     �  P	  ]   *?      $@100663493        �          oread   "     �         VB$CG$t_bool$S0     : *    �
      =          �  �?      Button6_Click_1     X	  �
  =  �?      $@100663493       �         VB$t_ref$L0      �         VB$t_ref$L1 "     �         VB$CG$t_bool$S0  �	  �
  t   �?           �          owrite    
  �
  
   �?          �          i        �	  �
  t   ?@          �          owrite   �
  �
  
   l@          �          i           : *    h      !           �  �@      Button5_Click_1        d  !   �@      $@100663493      : *    �      1           �  �@      Button4_Click_1     l  �  1   �@      $@100663493      : *    @                 �  A      Button2_Click_1     �  <     A      $@100663493      N *    �      G           �  4A      ListBox_Standard_MouseDoubleClick_1     D  �  G   4A      $@100663493      > *    0
      =           �  {A      Button_AddNote_Click_1  �  ,
  =   {A      $@100663493      N *    �
                 �  �A      ListBox_UsedNotes_MouseDoubleClick_1    4
  �
     �A      $@100663493      : *                     �  �A      Label4_MouseClick   �
       �A      $@100663493      : *    �                 �  �A      Label5_MouseClick      �     �A      $@100663493      : *    �                 �  �A      Label6_MouseClick   �  �     �A      $@100663493      : *    `                 �  �A      Label7_MouseClick   �  \     �A      $@100663493      : *    �                 �  	B      Label8_MouseClick   d  �     	B      $@100663493      : *    8                 �  B      Label9_MouseClick   �  4     B      $@100663493      6 *    �                 �  %B      Timer1_Tick     <  �     %B      $@100663493        �          t       R *    H      �          �  @B      ListBox_NSMjobfile_SelectedIndexChanged     �  D  �  @B      $@100663493       �         VB$t_ref$L0      �         VB$t_ref$L1   
   �         VB$t_ref$L2 "     �         VB$CG$t_bool$S0    @  �  �B           �          i        �          iint         �          jf       �          jfint        �          k        �          kint         �          m        �          mint     �  �     C          �          j      �       qC       	   �          l      �  <     �C       
   �          n           N *    �      &           �  -D      ListBox_NSMjobfile_MouseDoubleClick     L  �  &   -D      $@100663493        �          i       R *    l      �           �  SD      ListBox_NSMcaddshops_SelectedIndexChanged   �  h  �   SD      $@100663493        �          a        �          i   "     �         VB$t_array$S0        �         VB$t_ref$L0 "     �         VB$t_array$S1   "     �         VB$CG$t_bool$S0  8  d  +   �D          �          b        �          z         J *           @           �  9E      ListBox_nsmPlans_MouseDoubleClick   p  �  @   9E      $@100663493        �          i       N *    �      @           �  yE      ListBox_nsmworkorder_MouseDoubleClick     �  @   yE      $@100663493        �          i       N *    0      Z           �  �E      ListBox_nsmAutocad_MouseDoubleClick     �  ,  Z   �E      $@100663493        �          i       N *    �                �  F      ListBox_NCjobfile_SelectedIndexChanged  4  �    F      $@100663493    
   �         VB$t_ref$L0 "     �         VB$t_array$S0        �         VB$t_ref$L1   
   �         VB$t_ref$L2 "     �         VB$CG$t_bool$S0  �  �  �  YF           �          i        �          jf       �          k        �          m    T    .   �F          �          j        �          z      T  `  .   *G          �          l        �          z      T  �  .   �G          �          n     	   �          z           R *    D      �           �  H      ListBox_NCcaddshops_SelectedIndexChanged    �  @  �   H      $@100663493        �          a        �          i   "     �         VB$t_array$S0        �         VB$t_ref$L0 "     �         VB$t_array$S1   "     �         VB$CG$t_bool$S0    <  +   �H          �          b        �          z         J *    �      &           �  �H      ListBox_NCjobfile_MouseDoubleClick  H  �  &   �H      $@100663493        �          i       J *    l      Z           �  %I      ListBox_NCautocad_MouseDoubleClick  �  h  Z   %I      $@100663493        �          i       N *          @           �  I      ListBox_NCcaddshops_MouseDoubleClick    p     @   I      $@100663493        �          i       N *    �      @           �  �I      ListBox_NCworkorders_MouseDoubleClick     �  @   �I      $@100663493        �          i       J *    0      @           �  �I      ListBox_NCplans_MouseDoubleClick    �  ,  @   �I      $@100663493        �          i       R *          )           �  ?J      ListBoxDrawingsStandards_MouseDoubleClick   4     )   ?J      $@100663493        �          file         �          loc      �          open        > *    t                 �  hJ      PictureBox1_MouseClick    p     hJ      $@100663493      6 *    �                 �  vJ      Panel3_Paint    x  �     vJ      $@100663493      6 *    H!      5          �  yJ      Timer2_Tick     �  D!  5  yJ      $@100663493  "     �         VB$CG$t_bool$S0     �   t   �J           �          line         �          oread        �          owrite        @!  z   1K          �          line         �          oread        �          owrite        6 *    D"      \          �  �K      Button7_Click   L!  @"  \  �K      $@100663493  "     �         VB$CG$t_bool$S0  �!  "  k   L           �          owrite     �!  <"  k   �L          �          owrite        B *    �"                 �  
M      TextBox_outgoing_KeyDown    H"  �"     
M      $@100663493  "      �         VB$CG$t_bool$S0     6 *    D#      
           �  (M      Label10_Click   �"  @#  
   (M      $@100663493      J *    �#      %           �  2M      ListBox_Startup_MouseDoubleClick    H#  �#  %   2M      $@100663493        �          prog        B *    �$      V           �  WM      Button_timesheet_add_Click  �#  �$  V   WM      $@100663493       �         VB$t_ref$L0 "     �         VB$CG$t_bool$S0  $$  �$  .   fM           �          i         R *    �%      V           �  �M      ListBox_timesheet_jobs_MouseDoubleClick     �$  �%  V   �M      $@100663493        �          j   "     �         VB$CG$t_bool$S0     J *    \&      H           �  N      Button_timesheet_startstop_Click    �%  X&  H   N      $@100663493  "     �         VB$CG$t_bool$S0  �%  T&  '   !N           �          d         �   `   �    A                 ����        $   "     �-     �	 ' 	 2           8   ����  �   �   �    1          �         �     �   	  �   ����   
  �!     �"   ����$     �%   
  �-   ����.     �/     � @ 	  
 ?    % 
    	  
 &   	    �   �"  	    �3      �  t"        �     �     �     �$     �0     �<     �H     �T      �`   !  �l   "  �x   #  ��   $  ��   %  ��   &  ��   '  ��   (  ��   )  ��   *  ��   +  ��   ,  ��   -  ��   .  �  /  �  0  �   1  �,  2  �8  3  �D  4  �P  5  �\  6  �h  7  �t  8  ��  9  ��  :  ��  ;  ��  <  ��  =  ��  >  ��  ?  ��  @  ��  A  ��  B  ��  C  �  D  �  E  �  F  �(  G  �4  H  �@  I  �L  J  �X  K  �d  L  �p  M  �|  N  ��  O  ��  P  ��  Q  ��  R  ��  S  ��  T  ��  U  ��  V  ��  W  �   X  �  Y  �  Z  �$  [  �0  \  �<  ]  �H  ^  �T  _  �`  `  �l  a  �x  b  ��  c  ��  d  ��  e  ��  f  ��  g  ��  h  ��  i  ��  j  ��  k  ��  l  �  m  �  n  �  o  �*  p  �6  q  �B  r  �N  s  �Z  t  �f  u  �r 