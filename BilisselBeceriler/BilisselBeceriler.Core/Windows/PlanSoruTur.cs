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
	public class PlanSoruTur 
	{
		#region Private Members
		
		// Variabili di stato
		private bool _isChanged;
		private bool _isDeleted;

		// Primary Key(s) 
		private long _id; 
		
		// Foreign Keys mappate come Many-To-One 
		private Plan _planref; 
		private SoruTur _soruturref; 
		
		// Properties 
		private byte _secenekadet; 
		private byte _dogrusecenekadet; 
		
		// One-to-many relations 
		private IList<BelgePlanSoruTur> _listBelgePlanSoruTur;
		private IList<PlanSoruTurZorlukAyar> _listPlanSoruTurZorlukAyar;		

		#endregion
		
		#region Default ( Empty ) Class Constructor
		
		/// <summary>
		/// default constructor
		/// </summary>
		public PlanSoruTur()
		{
			_id = 0; 
			_planref = null; 
			_soruturref = null; 
			_secenekadet = 0; 
			_dogrusecenekadet = 0; 
			_listBelgePlanSoruTur = null; 
			_listPlanSoruTurZorlukAyar = null; 
		}
		
		#endregion // End of Default ( Empty ) Class Constructor
		
		#region Full Constructor
		
		/// <summary>
		/// full constructor
		/// </summary>
		public PlanSoruTur(long id, Plan planref, SoruTur soruturref, byte secenekadet, byte dogrusecenekadet)
		{
			_id = id; 
			_planref = planref; 
			_soruturref = soruturref; 
			_secenekadet = secenekadet; 
			_dogrusecenekadet = dogrusecenekadet; 
			_listBelgePlanSoruTur = null; 
			_listPlanSoruTurZorlukAyar = null; 
		}
		
		#endregion // End Full Constructor
		
		#region Required Fields Only Constructor
		
		/// <summary>
		/// required (not null) fields only constructor
		/// </summary>
		public PlanSoruTur(long id, Plan planref, SoruTur soruturref)
		{
			_id = id; 
			_planref = planref; 
			_soruturref = soruturref; 
			_secenekadet = 0; 
			_dogrusecenekadet = 0; 
			_listBelgePlanSoruTur = null; 
			_listPlanSoruTurZorlukAyar = null; 
		}
		
		#endregion // End Required Fields Only Constructor

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
		/// İlgili Planın Id si
		/// </summary>		
		public virtual Plan PlanRef
		{
			get { return _planref; }
			set { _isChanged |= (_planref != value); _planref = value; }
		} 
	  
		/// <summary>
		/// İlgili Soru Türünün Id si
		/// </summary>		
		public virtual SoruTur SoruTurRef
		{
			get { return _soruturref; }
			set { _isChanged |= (_soruturref != value); _soruturref = value; }
		} 
	  
		/// <summary>
		/// Üretilecek sorularda, eğer varsa seçenek sayısının tutulduğu yer.
		/// </summary>		
		public virtual byte SecenekAdet
		{
			get { return _secenekadet; }
			set { _isChanged |= (_secenekadet != value); _secenekadet = value; }
		} 
	  
		/// <summary>
		/// Oluşturulacak sorudaki (eğer varsa) seçeneklerden kaç tanesinin doğru seçenek olacağının tutulduğu yerdir.
		/// </summary>		
		public virtual byte DogruSecenekAdet
		{
			get { return _dogrusecenekadet; }
			set { _isChanged |= (_dogrusecenekadet != value); _dogrusecenekadet = value; }
		} 
	  
		/// <summary>
		/// 
		/// </summary>		
		public virtual IList<BelgePlanSoruTur> ListBelgePlanSoruTur
		{
			get { return _listBelgePlanSoruTur; }
			set { _isChanged |= (_listBelgePlanSoruTur != value); _listBelgePlanSoruTur = value; }
		} 
	  
		/// <summary>
		/// 
		/// </summary>		
		public virtual IList<PlanSoruTurZorlukAyar> ListPlanSoruTurZorlukAyar
		{
			get { return _listPlanSoruTurZorlukAyar; }
			set { _isChanged |= (_listPlanSoruTurZorlukAyar != value); _listPlanSoruTurZorlukAyar = value; }
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
			PlanSoruTur castObj = (PlanSoruTur)obj; 
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