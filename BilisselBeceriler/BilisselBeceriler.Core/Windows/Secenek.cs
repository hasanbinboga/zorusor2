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
	public class Secenek 
	{
		#region Private Members
		
		// Variabili di stato
		private bool _isChanged;
		private bool _isDeleted;

		// Primary Key(s) 
		private long _id; 
		
		// Foreign Keys mappate come Many-To-One 
		private Soru _soruref; 
		
		// Properties 
		private string _resimmetadata; 
		private bool _dogrucevapmi; 
		private byte _indeks; 		

		#endregion
		
		#region Default ( Empty ) Class Constructor
		
		/// <summary>
		/// default constructor
		/// </summary>
		public Secenek()
		{
			_id = 0; 
			_soruref = null; 
			_resimmetadata = null; 
			_dogrucevapmi = false; 
			_indeks = 0; 
		}
		
		#endregion // End of Default ( Empty ) Class Constructor
		
		#region Full Constructor
		
		/// <summary>
		/// full constructor
		/// </summary>
		public Secenek(long id, Soru soruref, string resimmetadata, bool dogrucevapmi, byte indeks)
		{
			_id = id; 
			_soruref = soruref; 
			_resimmetadata = resimmetadata; 
			_dogrucevapmi = dogrucevapmi; 
			_indeks = indeks; 
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
		/// Seçeneğin ait olduğu sorunu Id si
		/// </summary>		
		public virtual Soru SoruRef
		{
			get { return _soruref; }
			set { _isChanged |= (_soruref != value); _soruref = value; }
		} 
	  
		/// <summary>
		/// Seçenek resmini oluşturan havuz, parça, varyans ve figürelerin Id lerinin tutulduğu yerdir.
		/// </summary>		
		public virtual string ResimMetaData
		{
			get { return _resimmetadata; }
			set	
			{
				if ( value != null )
					if( value.Length > 2147483647)
						throw new ArgumentOutOfRangeException("Invalid value for ResimMetaData", value, value.ToString());
				
				_isChanged |= (_resimmetadata != value); _resimmetadata = value;
			}
		} 
	  
		/// <summary>
		/// Seçeneğin doğru cevap olup olamdığının tutulduğu alandır.
		/// </summary>		
		public virtual bool DogruCevapMi
		{
			get { return _dogrucevapmi; }
			set { _isChanged |= (_dogrucevapmi != value); _dogrucevapmi = value; }
		} 
	  
		/// <summary>
		/// İlgili seçeneğin, tüm seçenekler arasında hangi konumda olduğunu belirten indekstir. 1 den başlar.
		/// </summary>		
		public virtual byte Indeks
		{
			get { return _indeks; }
			set { _isChanged |= (_indeks != value); _indeks = value; }
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
			Secenek castObj = (Secenek)obj; 
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