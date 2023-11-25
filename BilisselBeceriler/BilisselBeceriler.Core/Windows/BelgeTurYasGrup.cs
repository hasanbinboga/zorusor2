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
	public class BelgeTurYasGrup 
	{
		#region Private Members
		
		// Variabili di stato
		private bool _isChanged;
		private bool _isDeleted;

		// Primary Key(s) 
		private long _id; 
		
		// Foreign Keys mappate come Many-To-One 
		private BelgeTur _belgeturref; 
		
		// Properties 
		private long _yasgrupref; 
		private int _standartsayfaadet; 		

		#endregion
		
		#region Default ( Empty ) Class Constructor
		
		/// <summary>
		/// default constructor
		/// </summary>
		public BelgeTurYasGrup()
		{
			_id = 0; 
			_belgeturref = null; 
			_yasgrupref = 0; 
			_standartsayfaadet = 0; 
		}
		
		#endregion // End of Default ( Empty ) Class Constructor
		
		#region Full Constructor
		
		/// <summary>
		/// full constructor
		/// </summary>
		public BelgeTurYasGrup(long id, BelgeTur belgeturref, long yasgrupref, int standartsayfaadet)
		{
			_id = id; 
			_belgeturref = belgeturref; 
			_yasgrupref = yasgrupref; 
			_standartsayfaadet = standartsayfaadet; 
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
		/// İlgili BelgeTürünün Idsi
		/// </summary>		
		public virtual BelgeTur BelgeTurRef
		{
			get { return _belgeturref; }
			set { _isChanged |= (_belgeturref != value); _belgeturref = value; }
		} 
	  
		/// <summary>
		/// İlgili Yaş grubunun Id si
		/// </summary>		
		public virtual long YasGrupRef
		{
			get { return _yasgrupref; }
			set { _isChanged |= (_yasgrupref != value); _yasgrupref = value; }
		} 
	  
		/// <summary>
		/// İlgili Belgenin ilgili yaş grubu için standart sayfa adedi
		/// </summary>		
		public virtual int StandartSayfaAdet
		{
			get { return _standartsayfaadet; }
			set { _isChanged |= (_standartsayfaadet != value); _standartsayfaadet = value; }
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
			BelgeTurYasGrup castObj = (BelgeTurYasGrup)obj; 
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