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
	public class BelgeBireyselKural 
	{
		#region Private Members
		
		// Variabili di stato
		private bool _isChanged;
		private bool _isDeleted;

		// Primary Key(s) 
		private long _id; 
		
		// Foreign Keys mappate come Many-To-One 
		private Belge _belgeref; 
		
		// Properties 
		private long _bireyselturref; 
		private long _bireyselkuralref; 
		private int _baslangicsayfano; 
		private int _bitissayfano; 		

		#endregion
		
		#region Default ( Empty ) Class Constructor
		
		/// <summary>
		/// default constructor
		/// </summary>
		public BelgeBireyselKural()
		{
			_id = 0; 
			_belgeref = null; 
			_bireyselturref = 0; 
			_bireyselkuralref = 0; 
			_baslangicsayfano = 0; 
			_bitissayfano = 0; 
		}
		
		#endregion // End of Default ( Empty ) Class Constructor
		
		#region Full Constructor
		
		/// <summary>
		/// full constructor
		/// </summary>
		public BelgeBireyselKural(long id, Belge belgeref, long bireyselturref, long bireyselkuralref, int baslangicsayfano, int bitissayfano)
		{
			_id = id; 
			_belgeref = belgeref; 
			_bireyselturref = bireyselturref; 
			_bireyselkuralref = bireyselkuralref; 
			_baslangicsayfano = baslangicsayfano; 
			_bitissayfano = bitissayfano; 
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
		/// İlgili Belgenin Id si
		/// </summary>		
		public virtual Belge BelgeRef
		{
			get { return _belgeref; }
			set { _isChanged |= (_belgeref != value); _belgeref = value; }
		} 
	  
		/// <summary>
		/// Bireysellik türünün Id sidir. (Örneğin Kendisi, Kendisi+Arkadaşları, Kendisi+Çizgi Çocuklar, Hepsi, v.b.)
		/// </summary>		
		public virtual long BireyselTurRef
		{
			get { return _bireyselturref; }
			set { _isChanged |= (_bireyselturref != value); _bireyselturref = value; }
		} 
	  
		/// <summary>
		/// Bireyselilk Kuralının Idsidir. Yani Bireysel türü ile belirlenen resimlerin belgeye nasıl uygulanacağı bilgisinin tutulduğu alandır. (Örneğin Sayfalarda Aynı Resim, Soruda aynı resim, Çeldiricilerde Farklı Resim, boyama Sayfası, v.b.)
		/// </summary>		
		public virtual long BireyselKuralRef
		{
			get { return _bireyselkuralref; }
			set { _isChanged |= (_bireyselkuralref != value); _bireyselkuralref = value; }
		} 
	  
		/// <summary>
		/// Bireysel Kuralların uygulanacağı sayfalardan ilk sayfanın nosu. Burada sayfanın indeksi değil SayfaNosu tutulur.
		/// </summary>		
		public virtual int BaslangicSayfaNo
		{
			get { return _baslangicsayfano; }
			set { _isChanged |= (_baslangicsayfano != value); _baslangicsayfano = value; }
		} 
	  
		/// <summary>
		/// Bireysel Kuralların uygulanacağı sayfalardan son sayfanın nosu. Burada sayfanın indeksi değil SayfaNosu tutulur.
		/// </summary>		
		public virtual int BitisSayfaNo
		{
			get { return _bitissayfano; }
			set { _isChanged |= (_bitissayfano != value); _bitissayfano = value; }
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
			BelgeBireyselKural castObj = (BelgeBireyselKural)obj; 
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