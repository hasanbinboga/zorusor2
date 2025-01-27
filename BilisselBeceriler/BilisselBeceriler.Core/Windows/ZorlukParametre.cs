/*

insert license info here

*/

using System;
using System.Collections;
using System.Collections.Generic;


namespace BilisselBeceriler.Entities.Windows
{
	/// <summary>
	/// Generated by MyGeneration using the NHibernate Object Mapping 1.3.1 by Grimaldi Giuseppe (giuseppe.grimaldi@infracom.it)
	/// </summary>
	[Serializable]
	public class ZorlukParametre 
	{
		#region Private Members
		
		// Variabili di stato
		private bool _isChanged;
		private bool _isDeleted;

		// Primary Key(s) 
		private long _id; 
		
		// Foreign Keys mappate come Many-To-One 
		private ZorlukAyar _zorlukayarref; 
		
		// Properties 
		private string _ad; 
		private string _tip; 
		
		// One-to-many relations 
		private IList<PlanSoruTurZorlukAyarZorlukParametre> _listPlanSoruTurZorlukAyarZorlukParametre;		

		#endregion
		
		#region Default ( Empty ) Class Constructor
		
		/// <summary>
		/// default constructor
		/// </summary>
		public ZorlukParametre()
		{
			_id = 0; 
			_zorlukayarref = null; 
			_ad = null; 
			_tip = null; 
			_listPlanSoruTurZorlukAyarZorlukParametre = null; 
		}
		
		#endregion // End of Default ( Empty ) Class Constructor
		
		#region Full Constructor
		
		/// <summary>
		/// full constructor
		/// </summary>
		public ZorlukParametre(long id, ZorlukAyar zorlukayarref, string ad, string tip)
		{
			_id = id; 
			_zorlukayarref = zorlukayarref; 
			_ad = ad; 
			_tip = tip; 
			_listPlanSoruTurZorlukAyarZorlukParametre = null; 
		}
		
		#endregion // End Full Constructor

		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		public virtual long Id
		{
			get { return _id; }
			set { _isChanged |= (_id != value); _id = value; }
		} 
	  
		/// <summary>
		/// Zorluk parametresinin sahibi olan Zorluk Ayarının Id si
		/// </summary>		
		public virtual ZorlukAyar ZorlukAyarRef
		{
			get { return _zorlukayarref; }
			set { _isChanged |= (_zorlukayarref != value); _zorlukayarref = value; }
		} 
	  
		/// <summary>
		/// Parametrenin adı (Çıkacak Parça Adedi, Temel Parça Değişim Seviyesi, Değişecek Temel Parça Adedi, Eklenecek Parça Adedi, v.b.)
		/// </summary>		
		public virtual string Ad
		{
			get { return _ad; }
			set	
			{
				if ( value != null )
					if( value.Length > 80)
						throw new ArgumentOutOfRangeException("Invalid value for Ad", value, value.ToString());
				
				_isChanged |= (_ad != value); _ad = value;
			}
		} 
	  
		/// <summary>
		/// ilgili parametrenin tipi (int, double, decimal, enum type, v.b.)
		/// </summary>		
		public virtual string Tip
		{
			get { return _tip; }
			set	
			{
				if ( value != null )
					if( value.Length > 80)
						throw new ArgumentOutOfRangeException("Invalid value for Tip", value, value.ToString());
				
				_isChanged |= (_tip != value); _tip = value;
			}
		} 
	  
		/// <summary>
		/// 
		/// </summary>		
		public virtual IList<PlanSoruTurZorlukAyarZorlukParametre> ListPlanSoruTurZorlukAyarZorlukParametre
		{
			get { return _listPlanSoruTurZorlukAyarZorlukParametre; }
			set { _isChanged |= (_listPlanSoruTurZorlukAyarZorlukParametre != value); _listPlanSoruTurZorlukAyarZorlukParametre = value; }
		} 
	  
		/// <summary>
		/// Returns whether or not the object has changed it's values.
		/// </summary>
		public virtual bool IsChanged
		{
			get { return _isChanged; }
		}
		
		/// <summary>
		/// Returns whether or not the object has changed it's values.
		/// </summary>
		public virtual bool IsDeleted
		{
			get { return _isDeleted; }
		}
		
		#endregion 
		
		#region Public Functions

		/// <summary>
		/// mark the item as deleted
		/// </summary>
		public virtual void MarkAsDeleted()
		{
			_isDeleted = true;
			_isChanged = true;
		}
		
		#endregion
		
		#region Equals And HashCode Overrides
		
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			ZorlukParametre castObj = (ZorlukParametre)obj; 
			return ( castObj != null ) &&
				( this._id == castObj.Id );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{ 
			int hash = 57; 
			hash = 27 * hash * this._id.GetHashCode();
					
			return hash;		
			
		}
		
		#endregion
		
	}
}