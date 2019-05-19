using System;
using System.Data;
using System.Windows.Forms;

namespace TP_ArquiteturaComputadores.Classes
{
  public static class DiskService
  {
    private static string GetSize(double byteCount)
    {
      string size = "0 Bytes";
      if (byteCount >= 1073741824.0)
        size = string.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
      else if (byteCount >= 1048576.0)
        size = string.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
      else if (byteCount >= 1024.0)
        size = string.Format("{0:##.##}", byteCount / 1024.0) + " KB";
      else if (byteCount > 0 && byteCount < 1024.0)
        size = byteCount.ToString() + " Bytes";

      return size;
    }
    public static void GetInfo(DataGridView dtgDisk)
    {
      var drives = System.IO.DriveInfo.GetDrives();

      DataTable dataTable = new DataTable();
      dataTable = CriaDataTable();
      dtgDisk.DataSource = dataTable;

      foreach (var drive in drives)
      {
        if (drive.IsReady)
        {
          DataRow nData = dataTable.NewRow();
          nData[0] = drive.Name;
          nData[1] = drive.DriveFormat;
          nData[2] = GetSize(drive.TotalSize);
          nData[3] = GetSize(drive.TotalFreeSpace);
          dataTable.Rows.Add(nData);
        }
      }
    }
    public static DataTable CriaDataTable()
    {

      var dt = new DataTable();

      DataColumn dc;//nomes da colunas

      dc = new DataColumn();
      dc.DataType = Type.GetType("System.String");
      dc.ColumnName = "Nome";
      dc.Caption = "Nome";
      dc.AllowDBNull = true;
      dt.Columns.Add(dc);

      dc = new DataColumn();
      dc.DataType = Type.GetType("System.String");
      dc.ColumnName = "Sis. Arq.";
      dc.Caption = "Sis. Arq.";
      dc.DefaultValue = "";
      dc.AllowDBNull = false;
      dc.ReadOnly = true;
      dt.Columns.Add(dc);

      dc = new DataColumn();
      dc.DataType = Type.GetType("System.String");
      dc.ColumnName = "Capacidade";
      dc.Caption = "Capacidade";
      dc.AllowDBNull = true;
      dc.DefaultValue = "";
      dt.Columns.Add(dc);

      dc = new DataColumn();
      dc.DataType = Type.GetType("System.String");
      dc.ColumnName = "Espaço Livre";
      dc.Caption = "Espaço Livre";
      dc.AllowDBNull = true;
      dc.DefaultValue = "";
      dt.Columns.Add(dc);

      return dt; //retornado o dataTable preenchido 
    }
  }
}
