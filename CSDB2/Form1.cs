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
            new Shohin(); // コンストラクタの呼び出し
            InitializeComponent();
            try
            {
                resultLists.Items.AddRange(Shohin.getAll().ToArray());
                textBoxSQL.Text = Shohin.excutedSql;
            }
            catch(Exception ex)
            {
                textboxError.Text = ex.Message;
            }
            finally {
                textBoxSQL.Text = Shohin.excutedSql;
            }
        }

        // 検索ボタン
        private void button1_Click(object sender, EventArgs e)
        {
            resultLists.Items.Clear();
            try
            {
                resultLists.Items.AddRange(
                    Shohin.extractByCondition(
                        inputProCode.Text,
                        inputProName.Text, 
                        int.Parse(inputProPrice.Text != ""?inputProPrice.Text:"0")
                        ).ToArray()
                    );
                
            }
            catch (Exception ex)
            {
                textboxError.Text = ex.Message;
            }
            finally
            {
                Console.WriteLine(Shohin.excutedSql);
                textBoxSQL.Text = Shohin.excutedSql;
            }
        }
        //追加ボンタン
        private void button2_Click(object sender, EventArgs e)
        {
            // 追加処理
            try
            {
                Shohin newItem = new Shohin(inputProCode.Text, inputProName.Text, int.Parse(inputProPrice.Text));
                Shohin.insert(newItem);
            }catch(Exception ex)
            {

            }
            finally
            {

            }
        }
        // 更新ボタン
        private void button3_Click(object sender, EventArgs e)
        {

        }
        // 削除ボタン
        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
