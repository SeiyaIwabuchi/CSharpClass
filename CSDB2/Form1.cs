using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            new Shohin(); // コンストラクタの呼び出しで初期化
            new Note();
            InitializeComponent();
            refreshListBox();
            resultLists.SelectedIndex = 0;
        }

        private void refreshListBox()
        {
            try
            {
                resultLists.Items.Clear();
                resultLists.Items.AddRange(Shohin.getAll().ToArray());
            }
            catch (Exception ex)
            {
                textboxError.Text = string.Format("{0}\r\n{1}",ex.Message,ex.StackTrace);
            }
            finally
            {
                textBoxSQL.Text = Shohin.excutedSql;
            }
        }

        // 検索ボタン
        private void button1_Click(object sender, EventArgs e)
        {
            resultLists.Items.Clear();
            try
            {
                Shohin.excutedSql = "";
                resultLists.Items.AddRange(
                    Shohin.extractByCondition(
                        inputProCode.Text,
                        inputProName.Text, 
                        int.Parse(inputProPrice.Text != ""?inputProPrice.Text:"0")
                        ).ToArray()
                    );
                textboxError.Text = "";
                

            }
            catch (Exception ex)
            {
                textboxError.Text = ex.Message;
            }
            finally
            {
                textBoxSQL.Text = Shohin.excutedSql;
            }
        }
        //追加ボンタン
        private void button2_Click(object sender, EventArgs e)
        {
            // 追加処理
            try
            {
                Shohin.excutedSql = "";
                Shohin newItem = new Shohin(inputProCode.Text, inputProName.Text, int.Parse(inputProPrice.Text));
                newItem.insert();
                textboxError.Text = "";
                
            }
            catch(Exception ex)
            {
                textboxError.Text = ex.Message;
            }
            finally
            {
                textBoxSQL.Text = Shohin.excutedSql;
            }

            refreshListBox();

        }
        // 更新ボタン
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Shohin.excutedSql = "";
                ((Shohin)resultLists.SelectedItem).update(new Shohin(inputProCode.Text, inputProName.Text, int.Parse(inputProPrice.Text)));
                refreshListBox();
                textboxError.Text = "";
                
            }
            catch (Exception ex)
            {
                textboxError.Text = ex.Message;
            }
            finally
            {
                textBoxSQL.Text = Shohin.excutedSql;
            }
        }
        // 削除ボタン
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Shohin.excutedSql = "";
                ((Shohin)resultLists.SelectedItem).delete();
                refreshListBox();
                textboxError.Text = "";
                
            }
            catch (Exception ex)
            {
                textboxError.Text = ex.Message;
            }
            finally
            {
                textBoxSQL.Text = Shohin.excutedSql;
            }

        }

        private void resultLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputProCode.Text = ((Shohin)resultLists.SelectedItem).Pro_code.ToString();
            inputProName.Text = ((Shohin)resultLists.SelectedItem).Pro_name.ToString();
            inputProPrice.Text = ((Shohin)resultLists.SelectedItem).Pro_price.ToString();
        }
    }
}
