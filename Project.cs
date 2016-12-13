using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitTestWeb
{

    public class BaseObj
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class Project : BaseObj
    {
        public Project()
        {
            //ProjectStores = new ProjectStore[100];
            //Forms = new ProjectForm[100];
        }

        public ProjectStore[] ProjectStores { get; set; }

        public ProjectForm[] Forms { get; set; }
    }

    public class ProjectStore : BaseObj
    {

    }

    public class ProjectForm : BaseObj
    {

        public ProjectForm()
        {
            //FormLines = new FormLine[100];
        }

        public DateTime EnableDate { get; set; }
        public DateTime DisableDate { get; set; }

        public FormLine[] FormLines { get; set; }

        /// <summary>
        /// 标签 由此标签的门店才会显示此表单
        /// </summary>
        public string[] Flags { get; set; }
    }

    public class FormLine : BaseObj
    {

        public FormLine()
        {
            //Controls = new Control[100];
        }


        public FormControl[] Controls { get; set; }
    }

    public class FormControl : BaseObj
    {

    }


    public class FormControlResult : FormControl
    {
        public object Value { get; set; }
    }


    public class ProjectStoreData : BaseObj
    {
        public ProjectStore Store { get; set; }

        public FormControlResult[] Values { get; set; }
    }
}