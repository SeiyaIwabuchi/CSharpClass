using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDB2
{
    class SqlBuilder
    {
        string sql;

        public SqlBuilder()
        {
            this.sql = "";
        }
        public static string select(ModelColumn[] cols,Type table_, ConditionString conditionString = null)
        {
            var table = (Model)Activator.CreateInstance(table_);
            string colNames = string.Join(",",cols.Select(col => col.colName).ToArray());
            if(conditionString != null)
            {
                return string.Format("select {0} from {1} where {2}",colNames,table.tableName,conditionString.conditions);
            }
            else
            {
                return string.Format("select {0} from {1}", colNames, table.tableName);
            }
        }
        public static string insert(string[] cols, Type table_)
        {
            var table = (Model)Activator.CreateInstance(table_);
            string values = string.Join(",", cols.Select(str => str).ToArray());
            Console.WriteLine(string.Format("insert into {1} values({0})", values, table.tableName));
            return string.Format("insert into {1} values({0})", values,table.tableName);
        }
        public static string update(string[] cols, Type table_, ConditionString conditionString = null)
        {
            var table = (Model)Activator.CreateInstance(table_);
            string values = string.Join(",", cols.Select(str => str).ToArray());
            if(conditionString != null) 
                return string.Format("update {0} set {1} where {2}", table.tableName, values, conditionString.conditions);
            else
                return string.Format("update {0} set {1}", table.tableName, values);
        }
        public static string delete(Type table_, ConditionString conditionString = null)
        {
            // delete from tableName where aldsjf=123
            var table = (Model)Activator.CreateInstance(table_);
            if (conditionString != null)
                return string.Format("delete from {0} where {1}", table.tableName, conditionString.conditions);
            else
                return string.Format("delete from {0}", table.tableName);
        }

    }
    class ConditionString
    {
        public string conditions;

        public ConditionString(string conditions)
        {
            this.conditions = conditions;
        }
        public static ConditionString operator &(ConditionString a, ConditionString b)
        {
            return new ConditionString(string.Format("{0} and {1}",a.conditions,b.conditions));
        }
        public static ConditionString operator |(ConditionString a, ConditionString b)
        {
            return new ConditionString(string.Format("{0} or {1}", a.conditions, b.conditions));
        }
        public override string ToString()
        {
            return this.conditions.ToString();
        }
    }
    class ModelColumn
    {
        public string colName;
        public override string ToString()
        {
            return colName.ToString();
        }
    }
    class ModelString : ModelColumn
    {
        public string value = "";
        

        public string ColName { get => colName; set => colName = value; }

        public override string ToString()
        {
            return value.ToString();
        }
        public static ConditionString operator == (ModelString a, string str)
        {
            return new ConditionString(string.Format("{0}='{1}'",a.ColName,str));
        }
        public static ConditionString operator !=(ModelString a, string str)
        {
            return new ConditionString(string.Format("{0}!='{1}'", a.ColName, str));
        }
        public static ModelString operator +(ModelString a, string str)
        {
            a.value += str;
            return a;
        }
    }
    class ModelInt: ModelColumn
    {
        public int value = 0;

        public string ColName { get => colName; set => colName = value; }

        public override string ToString()
        {
            return value.ToString();
        }
        public static ConditionString operator ==(ModelInt a, int value)
        {

            return new ConditionString(string.Format("{0}={1}", a.ColName, value));
        }
        public static ConditionString operator !=(ModelInt a, int value)
        {
            return new ConditionString(string.Format("{0}!={1}", a.ColName, value));
        }
        public static ConditionString operator >(ModelInt a, int value)
        {
            return new ConditionString(string.Format("{0}>{1}", a.ColName, value));
        }
        public static ConditionString operator <(ModelInt a, int value)
        {
            return new ConditionString(string.Format("{0}<{1}", a.ColName, value));
        }
        public static ConditionString operator <=(ModelInt a, int value)
        {
            return new ConditionString(string.Format("{0}<={1}", a.ColName, value));
        }
        public static ConditionString operator >=(ModelInt a, int value)
        {
            return new ConditionString(string.Format("{0}>={1}", a.ColName, value));
        }
        public static ModelInt operator +(ModelInt a, int value)
        {
            a.value += value;
            return a;
        }
    }
    class ModelDouble : ModelColumn
    {
        public double value = 0;

        public string ColName { get => colName; set => colName = value; }

        public override string ToString()
        {
            return value.ToString();
        }
        public static ConditionString operator ==(ModelDouble a, double value)
        {

            return new ConditionString(string.Format("{0}={1}", a.ColName, value));
        }
        public static ConditionString operator !=(ModelDouble a, double value)
        {
            return new ConditionString(string.Format("{0}!={1}", a.ColName, value));
        }
        public static ConditionString operator >(ModelDouble a, double value)
        {
            return new ConditionString(string.Format("{0}>{1}", a.ColName, value));
        }
        public static ConditionString operator <(ModelDouble a, double value)
        {
            return new ConditionString(string.Format("{0}<{1}", a.ColName, value));
        }
        public static ConditionString operator <=(ModelDouble a, double value)
        {
            return new ConditionString(string.Format("{0}<={1}", a.ColName, value));
        }
        public static ConditionString operator >=(ModelDouble a, double value)
        {
            return new ConditionString(string.Format("{0}>={1}", a.ColName, value));
        }
        public static ModelDouble operator +(ModelDouble a, double value)
        {
            a.value += value;
            return a;
        }
    }

    class TModel : Model
    {
        // 比較演算子を用いてsqlのwhere句を生成するには文字列型、数値型を継承したそれぞれの独自のクラスを準備する必要がある。
        public ModelString code = new ModelString();
        public ModelString name = new ModelString();
        public ModelInt age = new ModelInt();
        public ModelDouble weight = new ModelDouble();

        public TModel()
        {
            this.tableName = this.GetType().Name;
            this.code.ColName = nameof(this.code);
            this.name.ColName = nameof(this.name);
            this.age.ColName = nameof(this.age);
            this.weight.ColName = nameof(this.weight);
        }

        public TModel(string code="", string name="", int age=0, double weight=0)
        {
            this.tableName = this.GetType().Name;
            this.code.ColName = nameof(this.code);
            this.name.ColName = nameof(this.name);
            this.age.ColName = nameof(this.age);
            this.weight.ColName = nameof(this.weight);
            this.Code += code;
            this.Name += name;
            this.Age += age;
            this.Weight += weight;
        }

        internal ModelString Code { get => code; set => code = value; }
        internal ModelString Name { get => name; set => name = value; }
        internal ModelInt Age { get => age; set => age = value; }
        internal ModelDouble Weight { get => weight; set => weight = value; }
    }
    class Note
    {
        public Note()
        {
            TModel t1 = new TModel("0001","oyama",11,44.5);
            TModel t2 = new TModel("0002", "yamazaki", 14, 40.5);
            Console.WriteLine(SqlBuilder.select(new ModelColumn[]{t1.code,t1.name,t1.age,t1.weight}, typeof(TModel),t1.weight >= 40 & t1.weight <= 100));
        }
    }
}
