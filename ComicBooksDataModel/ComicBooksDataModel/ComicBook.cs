using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBooksDataModel
{
    public class ComicBook
    {
		public virtual int Id { get; set; }
		public virtual string Title { get; set; }
		public virtual string Volume { get; set; }
		public virtual int Issue { get; set; }
		public virtual int Year { get; set; }
		public virtual int Month { get; set; }
		public virtual string Publisher { get; set; }
		public virtual string Writer { get; set; }
		public virtual string Inks { get; set; }
		public virtual string Letterer { get; set; }
		public virtual string Colourist { get; set; }
		public virtual string Editor { get; set; }
		public virtual string EditorInChief { get; set; }
		public virtual string Synopsis { get; set; }
		public virtual string Story { get; set; }
		public virtual string Part { get; set; }
	}
}
