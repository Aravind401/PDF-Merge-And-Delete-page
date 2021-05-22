using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.ComponentModel;


namespace PDFMergeDeleteSplit
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private string _pathname;
        private readonly List<string> pdflist = new List<string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.DoEvents();
        }

        private void merge_click(object sender, EventArgs e)
        {
            try
            {

                up.Text = string.Empty;
                down.Text = string.Empty;
                List<string> myList = FileSearch(dirpath.Text, null, "*.pdf");
                PdfReader reader = null;
                Document sourceDocument = null;
                PdfCopy pdfCopyProvider = null;
                string[] lstFiles = myList.ToArray();
                if (lstFiles.Count() == 1) return;
                PdfImportedPage importedPage;
                var path = Path.Combine(Path.GetDirectoryName(dirpath.Text), Path.GetFileNameWithoutExtension(dirpath.Text));
                sourceDocument = new Document();
                DirectoryInfo parentDir = Directory.GetParent(path.EndsWith("\\") ? path : string.Concat(path, "\\"));
                try
                {
                    if (File.Exists(parentDir + "\\" + pdfname.Text + ".pdf"))
                    {
                        TaskDialog.Show("", "File name already Exist");
                        return;
                    }
                    else
                    {
                        pdfCopyProvider = new PdfCopy(sourceDocument, new FileStream(parentDir + "\\" + pdfname.Text + ".pdf", System.IO.FileMode.Create));

                        sourceDocument.Open();
                    }

                }
                catch (Exception ex) { TaskDialog.Show("" + ex.Message); ; }

                int sum = 0;
                int a = 0;
                int pages = 0;
                for (int f = 0; f < lstFiles.Length; f++)
                {

                    pages = GetNumberOfPages(lstFiles[f]);
                    if (pages < 0) continue;
                    a = 0;

                    reader = new PdfReader(lstFiles[f]);

                    for (int i = 1; i <= pages; i++)
                    {
                        if (reader == null) continue;
                        importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                        pdfCopyProvider.AddPage(importedPage);
                    }
                    a = Convert.ToInt32(pages);
                    sum += a;

                    reader.Close();
                }

                up.Text += sum;
                down.Text += myList.Count();

                pdfCopyProvider.Close();
                sourceDocument.Close();
                TaskDialog.Show("", "Completed");
                myList.Clear();
            }
            catch (Exception ex)
            { TaskDialog.Show("" + ex.Message); }
        }
        private List<string> FileSearch(string dir, string Folderpath = null, string Match = ".pdf", List<string> NotFound = default(List<string>))
        {
            if (Folderpath == null)
                Folderpath = dir;
            if (NotFound == null)
                NotFound = new List<string>();
            try
            {
                foreach (string f in Directory.GetFiles(dir, Match))
                {
                    string filename = f.Substring(Folderpath.Length);
                    NotFound.Add(f);
                    Console.WriteLine(filename);
                }
                foreach (string d in Directory.GetDirectories(dir))
                {
                    Console.WriteLine(d);
                    FileSearch(d, Folderpath, Match, NotFound);
                }

            }
            catch (System.Exception ex)
            {
                TaskDialog.Show("" + ex.Message);
            }
            return NotFound;
        }
        static int GetNumberOfPages(String FilePath)
        {
            PdfReader pdfReader = new PdfReader(FilePath);
            return pdfReader.NumberOfPages;
        }

        private void pdfdirectory_click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                dirpath.Text = dialog.FileName;
                _pathname = dialog.FileName;
                dirpath.Text = _pathname;
            }
        }

        private void SelFiles_click(object sender, EventArgs e)
        {
            try
            {
                up.Text = string.Empty;
                down.Text = string.Empty;
                PdfReader reader = null;
                Document sourceDocument = null;
                PdfCopy pdfCopyProvider = null;
                string[] lstFiles = pdflist.ToArray();
                if (lstFiles.Count() == 1) return;
                PdfImportedPage importedPage;
                var path = Path.Combine(Path.GetDirectoryName(selFiles.Text), Path.GetFileNameWithoutExtension(selFiles.Text));                             
                                       
                sourceDocument = new Document();
                DirectoryInfo parentDir = Directory.GetParent(path.EndsWith("\\") ? path : string.Concat(path, "\\"));
                var myParentDir = parentDir.Parent.FullName;
                try
                {
                    if (File.Exists(myParentDir + "\\" + pdfname.Text + ".pdf"))
                    {
                        TaskDialog.Show("", "File name already Exist");
                        return;

                    }
                    else
                    {
                        pdfCopyProvider = new PdfCopy(sourceDocument, new FileStream(myParentDir + "\\" + pdfname.Text + ".pdf", System.IO.FileMode.Create));
                        sourceDocument.Open();
                    }
                }
                catch (Exception ex) { TaskDialog.Show("" + ex.Message); }

                int sum = 0;
                int a = 0;
                int pages = 0;
                for (int f = 0; f < lstFiles.Length; f++)
                {

                    pages = GetNumberOfPages(lstFiles[f]);
                    if (pages < 0) continue;
                    a = 0;

                    reader = new PdfReader(lstFiles[f]);
                    for (int i = 1; i <= pages; i++)
                    {
                        if (reader == null) continue;
                        importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                        pdfCopyProvider.AddPage(importedPage);
                    }
                    a = Convert.ToInt32(pages);
                    sum += a;
                  
                    reader.Close();
                }
                up.Text += sum;
                down.Text += pdflist.Count();
                sourceDocument.Close();
                pdfCopyProvider.Close();
                pdflist.Clear();
                TaskDialog.Show("", "Completed");
            }
            catch (Exception ex)
            { TaskDialog.Show("", "No File Selected  " + ex.Message); }
        }

        private void btn_SelFiles(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                od.Filter = "PDF files|*.pdf";
                od.Multiselect = true;
                string tb_path = null;
                if (od.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string tempFolder = System.IO.Path.GetTempPath();

                    foreach (string fileName in od.FileNames)
                    {
                        
                        pdflist.Add(fileName);
                    }
                    tb_path = od.FileName;
                   selFiles.Text = tb_path;
                }
            }
            catch (Exception ex) { throw new Exception("check the input file"); }
        }

        private void Del_button(object sender, EventArgs e)
        {
            try
            {
                up.Text = string.Empty;
                down.Text = string.Empty;
                int a = 0;
                string intval = string.Empty;
                string delval = string.Empty;
                var path = Path.Combine(Path.GetDirectoryName(deletepdffile.Text), Path.GetFileNameWithoutExtension(deletepdffile.Text));
                string sourceFile = deletepdffile.Text;
                List<string> pageval = new List<string>();
                PdfReader reader = new PdfReader(deletepdffile.Text);
                int sum = 0;
                var vn = 0;
                var n = 0;
                int page;
                foreach (var sn in number.Text.Split(',', '.'))
                {
                    vn = Convert.ToInt32(sn);
                    pageval.Add(vn.ToString());
                }
                for (page = 1; page <= reader.NumberOfPages; page++)
                {
                    n = Convert.ToInt32(page);

                    if (!pageval.Contains(n.ToString()))
                    {
                        intval = intval + page + ",";
                        a = Convert.ToInt32(page);
                    }
                }
                if (page <= vn)
                {
                    TaskDialog.Show("", "Pdf page count will be " + n + " and you typed number " + vn);
                    return;
                }

                try
                {
                    var X = Convert.ToInt32(pageval.Count());
                    sum += n - X;

                    up.Text += "1";
                    reader.SelectPages(intval);
                    DirectoryInfo parentDir = Directory.GetParent(path.EndsWith("\\") ? path : string.Concat(path, "\\"));
                    // The result is available here
                    var myParentDir = parentDir.Parent.FullName;
                    try
                    {
                        if (File.Exists(myParentDir + "\\" + pdfname.Text + ".pdf"))
                        {
                            TaskDialog.Show("", "File name already Exist");
                            return;

                        }
                        else
                        {
                          
                            PdfStamper stamper = new PdfStamper(reader, new FileStream(myParentDir + "\\" + pdfname.Text + ".pdf", FileMode.Create));
                            stamper.Close();
                        }
                    }
                    catch (Exception ex) { TaskDialog.Show("", "" + ex.Message); }
                    down.Text += sum;

                    reader.Close();
                    TaskDialog.Show("", "completed");
                }
                catch (Exception ex) { TaskDialog.Show("", "File Name Already Existed"+ex.Message); }


            }
            catch (Exception ex) { TaskDialog.Show("", "No File Selected" + ex); }
        }      

        private void delpage(object sender, EventArgs e)
        {
            string tb_path = null;
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "pdf Files | *.pdf; *.pdf; *.pdf";
            openfiledialog1.Multiselect = false;
            Cursor.Current = Cursors.WaitCursor;
            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tb_path = openfiledialog1.FileName;
            }
            deletepdffile.Text = tb_path;
        }

        private void pdf_Split(object sender, EventArgs e)
        {
            string tb_path = null;
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "Excel Files | *.pdf; *.pdf; *.pdf";
            openfiledialog1.Multiselect = false;
            Cursor.Current = Cursors.WaitCursor;
            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tb_path = openfiledialog1.FileName;
            }
            pdfsplit.Text = tb_path;
        }

        private void pdf_split(object sender, EventArgs e)
        {
            up.Text = string.Empty;
            down.Text = string.Empty;

            try
            {
                if (startpages.Text == null && (endpages.Text == null))
                {
                    TaskDialog.Show("", "Start Page and end page cannot not empty");
                    return;
                }
            }
            catch (Exception ex)
            {
                TaskDialog.Show("", "Start Page and end page cannot not empty");
                return;
            }

            try
            {

                int startpage = Convert.ToInt32(startpages.Text);
                int endpage = Convert.ToInt32(endpages.Text);

                PdfReader reader = null;
                Document sourceDocument = null;
                PdfCopy pdfCopyProvider = null;
                PdfImportedPage importedPage = null;
                var path = Path.Combine(Path.GetDirectoryName(pdfsplit.Text), Path.GetFileNameWithoutExtension(pdfsplit.Text));
                DirectoryInfo parentDir = Directory.GetParent(path.EndsWith("\\") ? path : string.Concat(path, "\\"));
                // The result is available here
                var myParentDir = parentDir.Parent.FullName;
                reader = new PdfReader(pdfsplit.Text);
                int pages = GetNumberOfPages(pdfsplit.Text);
                sourceDocument = new Document(reader.GetPageSizeWithRotation(startpage));
                try
                {
                    if (File.Exists(myParentDir + "\\" + pdfname.Text + ".pdf"))
                    {
                        TaskDialog.Show("", "File name already Exist");
                        return;

                    }
                    if (endpage > pages)
                    {
                        TaskDialog.Show("", "There are " + pages + " pages in the pdf");
                        return;
                    }
                    if (startpage >= endpage)
                    {
                        TaskDialog.Show("", "Check the page Number"); return;
                    }


                    else
                    {
                       
                        pdfCopyProvider = new PdfCopy(sourceDocument, new FileStream(myParentDir + "\\" + pdfname.Text + ".pdf", System.IO.FileMode.Create));
                        sourceDocument.Open();
                    }

                }
                catch (Exception ex) { }
                int count = 0;
                for (int i = startpage; i <= endpage; i++)
                {
                    importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                    pdfCopyProvider.AddPage(importedPage);
                    count = count + 1;
                }
                sourceDocument.Close();
                reader.Close();
                up.Text += "1";
                down.Text = count.ToString();
                TaskDialog.Show("", "Completed");
            }
            catch (Exception ex) { TaskDialog.Show("", ""+ex.Message); }
        }
    }
}
