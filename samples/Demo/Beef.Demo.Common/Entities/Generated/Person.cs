/*
 * This file is automatically generated; any changes will be lost. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Beef.RefData;
using Newtonsoft.Json;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Entities
{
    /// <summary>
    /// Represents the Person entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Person : EntityBase, IETag, IChangeLog
    {
        #region PropertyNames
      
        /// <summary>
        /// Represents the <see cref="Id"/> property name.
        /// </summary>
        public const string Property_Id = nameof(Id);

        /// <summary>
        /// Represents the <see cref="FirstName"/> property name.
        /// </summary>
        public const string Property_FirstName = nameof(FirstName);

        /// <summary>
        /// Represents the <see cref="LastName"/> property name.
        /// </summary>
        public const string Property_LastName = nameof(LastName);

        /// <summary>
        /// Represents the <see cref="UniqueCode"/> property name.
        /// </summary>
        public const string Property_UniqueCode = nameof(UniqueCode);

        /// <summary>
        /// Represents the <see cref="Gender"/> property name.
        /// </summary>
        public const string Property_Gender = nameof(Gender);

        /// <summary>
        /// Represents the <see cref="Birthday"/> property name.
        /// </summary>
        public const string Property_Birthday = nameof(Birthday);

        /// <summary>
        /// Represents the <see cref="Address"/> property name.
        /// </summary>
        public const string Property_Address = nameof(Address);

        /// <summary>
        /// Represents the <see cref="ETag"/> property name.
        /// </summary>
        public const string Property_ETag = nameof(ETag);

        /// <summary>
        /// Represents the <see cref="ChangeLog"/> property name.
        /// </summary>
        public const string Property_ChangeLog = nameof(ChangeLog);

        #endregion

        #region Privates

        private Guid _id;
        private string _firstName;
        private string _lastName;
        private string _uniqueCode;
        private string _genderSid;
        private DateTime _birthday;
        private Address _address;
        private string _eTag;
        private ChangeLog _changeLog;

        #endregion

        #region Constructor
      
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
            this.PersonConstructor();
        }
        
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="Person"/> identifier.
        /// </summary>
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Identifier")]
        public Guid Id
        {
            get { return this._id; }
            set { SetValue<Guid>(ref this._id, value, false, false, Property_Id); }
        }

        /// <summary>
        /// Gets or sets the First Name.
        /// </summary>
        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="First Name")]
        public string FirstName
        {
            get { return this._firstName; }
            set { SetValue(ref this._firstName, value, false, StringTrim.End, StringTransform.EmptyToNull, Property_FirstName); }
        }

        /// <summary>
        /// Gets or sets the Last Name.
        /// </summary>
        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Last Name")]
        public string LastName
        {
            get { return this._lastName; }
            set { SetValue(ref this._lastName, value, false, StringTrim.End, StringTransform.EmptyToNull, Property_LastName); }
        }

        /// <summary>
        /// Gets or sets the Unique Code.
        /// </summary>
        [JsonProperty("uniqueCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Unique Code")]
        public string UniqueCode
        {
            get { return this._uniqueCode; }
            set { SetValue(ref this._uniqueCode, value, false, StringTrim.End, StringTransform.EmptyToNull, Property_UniqueCode); }
        }

        /// <summary>
        /// Gets or sets the <see cref="Gender"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonProperty("gender", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Gender")]
        public string GenderSid
        {
            get { return this._genderSid; }
            set { SetValue(ref this._genderSid, value, false, StringTrim.End, StringTransform.EmptyToNull, Property_Gender); }
        }

        /// <summary>
        /// Gets or sets the Gender (see <see cref="RefDataNamespace.Gender"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [Display(Name="Gender")]
        public RefDataNamespace.Gender Gender
        {
            get { return this._genderSid; }
            set { SetValue<string>(ref this._genderSid, value, false, false, Property_Gender); }
        }

        /// <summary>
        /// Gets or sets the Birthday.
        /// </summary>
        [JsonProperty("birthday", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Birthday")]
        [DisplayFormat(DataFormatString = Beef.Entities.StringFormat.DateOnlyFormat)]
        public DateTime Birthday
        {
            get { return this._birthday; }
            set { SetValue(ref this._birthday, value, false, DateTimeTransform.DateOnly, Property_Birthday); }
        }

        /// <summary>
        /// Gets or sets the Address (see <see cref="Address"/>).
        /// </summary>
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Address")]
        public Address Address
        {
            get { return this._address; }
            set { SetValue<Address>(ref this._address, value, false, false, Property_Address); }
        }

        /// <summary>
        /// Gets or sets the ETag.
        /// </summary>
        [JsonProperty("etag", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="ETag")]
        public string ETag
        {
            get { return this._eTag; }
            set { SetValue(ref this._eTag, value, false, StringTrim.End, StringTransform.EmptyToNull, Property_ETag); }
        }

        /// <summary>
        /// Gets or sets the Change Log (see <see cref="ChangeLog"/>).
        /// </summary>
        [JsonProperty("changeLog", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Change Log")]
        public ChangeLog ChangeLog
        {
            get { return this._changeLog; }
            set { SetValue<ChangeLog>(ref this._changeLog, value, false, false, Property_ChangeLog); }
        }

        #endregion

        #region UniqueKey
      
        /// <summary>
        /// Indicates whether the <see cref="Person"/> has a <see cref="UniqueKey"/> value.
        /// </summary>
        public override bool HasUniqueKey
        {
            get { return true; }
        }
        
        /// <summary>
        /// Gets the list of property names that represent the unique key.
        /// </summary>
        public override string[] UniqueKeyProperties => new string[] { Property_Id };
        
        /// <summary>
        /// Creates the <see cref="UniqueKey"/>.
        /// </summary>
        /// <returns>The <see cref="Beef.Entities.UniqueKey"/>.</returns>
        /// <param name="id">The <see cref="Id"/>.</param>
        public static UniqueKey CreateUniqueKey(Guid id)
        {
            return new UniqueKey(id);
        }
          
        /// <summary>
        /// Gets the <see cref="UniqueKey"/>.
        /// </summary>
        /// <remarks>
        /// The <b>UniqueKey</b> key consists of the following property(s): <see cref="Id"/>.
        /// </remarks>
        public override UniqueKey UniqueKey
        {
            get { return new UniqueKey(this.Id); }
        }

        #endregion

        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="Person"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="Person"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<Person>(from);
            CopyFrom((Person)fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="Person"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="Person"/> to copy from.</param>
        public void CopyFrom(Person from)
        {
            CopyFrom((EntityBase)from);
            this.Id = from.Id;
            this.FirstName = from.FirstName;
            this.LastName = from.LastName;
            this.UniqueCode = from.UniqueCode;
            this.Gender = from.Gender;
            this.Birthday = from.Birthday;
            this.Address = (from.Address == null) ? null : (Address)from.Address.Clone();
            this.ETag = from.ETag;
            this.ChangeLog = from.ChangeLog;

            this.OnAfterCopyFrom(from);
        }
    
        #endregion
        
        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="Person"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="Person"/>.</returns>
        public override object Clone()
        {
            var clone = new Person();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="Person"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();
            this.Id = Cleaner.Clean<Guid>(this.Id);
            this.FirstName = Cleaner.Clean(this.FirstName, StringTrim.End, StringTransform.EmptyToNull);
            this.LastName = Cleaner.Clean(this.LastName, StringTrim.End, StringTransform.EmptyToNull);
            this.UniqueCode = Cleaner.Clean(this.UniqueCode, StringTrim.End, StringTransform.EmptyToNull);
            this.Gender = Cleaner.Clean<RefDataNamespace.Gender>(this.Gender);
            this.Birthday = Cleaner.Clean(this.Birthday, DateTimeTransform.DateOnly);
            this.Address = Cleaner.Clean<Address>(this.Address);
            this.ETag = Cleaner.Clean(this.ETag, StringTrim.End, StringTransform.EmptyToNull);
            this.ChangeLog = Cleaner.Clean<ChangeLog>(this.ChangeLog);

            this.OnAfterCleanUp();
        }
    
        /// <summary>
        /// Indicates whether considered initial; i.e. all properties have their initial value.
        /// </summary>
        /// <returns><c>true</c> indicates is initial; otherwise, <c>false</c>.</returns>
        public override bool IsInitial
        {
            get
            {
                return Cleaner.IsInitial(this.Id)
                    && Cleaner.IsInitial(this.FirstName)
                    && Cleaner.IsInitial(this.LastName)
                    && Cleaner.IsInitial(this.UniqueCode)
                    && Cleaner.IsInitial(this.Gender)
                    && Cleaner.IsInitial(this.Birthday)
                    && Cleaner.IsInitial(this.Address)
                    && Cleaner.IsInitial(this.ETag)
                    && Cleaner.IsInitial(this.ChangeLog);
            }
        }

        #endregion

        #region PartialMethods
      
        partial void PersonConstructor();

        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(Person from);

        #endregion
    } 

    /// <summary>
    /// Represents a <see cref="Person"/> collection.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Tightly coupled; OK.")]
    public partial class PersonCollection : EntityBaseCollection<Person>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollection"/> class.
        /// </summary>
        public PersonCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollection"/> class with an entity range.
        /// </summary>
        /// <param name="entities">The <see cref="Person"/> entities.</param>
        public PersonCollection(IEnumerable<Person> entities)
        {
            AddRange(entities);
        }

        #endregion

        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="PersonCollection"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="PersonCollection"/>.</returns>
        public override object Clone()
        {
            var clone = new PersonCollection();
            foreach (Person item in this)
            {
                clone.Add((Person)item.Clone());
            }
                
            return clone;
        }
        
        #endregion

        #region Operator

        /// <summary>
        /// An implicit cast from a <see cref="PersonCollectionResult"/> to a <see cref="PersonCollection"/>.
        /// </summary>
        /// <param name="result">The <see cref="PersonCollectionResult"/>.</param>
        /// <returns>The corresponding <see cref="PersonCollection"/>.</returns>
        public static implicit operator PersonCollection(PersonCollectionResult result)
        {
            return result?.Result;
        }

        #endregion
    }

    /// <summary>
    /// Represents a <see cref="Person"/> collection result.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Tightly coupled; OK.")]
    public class PersonCollectionResult : EntityCollectionResult<PersonCollection, Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollectionResult"/> class.
        /// </summary>
        public PersonCollectionResult() { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollectionResult"/> class with default <see cref="PagingArgs"/>.
        /// </summary>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public PersonCollectionResult(PagingArgs paging) : base(paging) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCollectionResult"/> class with a <paramref name="collection"/> of items to add.
        /// </summary>
        /// <param name="collection">A collection containing items to add.</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public PersonCollectionResult(IEnumerable<Person> collection, PagingArgs paging = null) : base(paging)
        {
            this.Result.AddRange(collection);
        }
        
        /// <summary>
        /// Creates a deep copy of the <see cref="PersonCollectionResult"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="PersonCollectionResult"/>.</returns>
        public override object Clone()
        {
            var clone = new PersonCollectionResult();
            clone.CopyFrom(this);
            return clone;
        }
    }
}