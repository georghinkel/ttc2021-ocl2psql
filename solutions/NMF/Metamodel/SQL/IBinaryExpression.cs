//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2021.OclToSql.Sql
{
    
    
    /// <summary>
    /// The public interface for BinaryExpression
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(BinaryExpression))]
    [XmlDefaultImplementationTypeAttribute(typeof(BinaryExpression))]
    [ModelRepresentationClassAttribute("http://www.example.org/sql#//BinaryExpression")]
    public interface IBinaryExpression : IModelElement, IExpression
    {
        
        /// <summary>
        /// The leftExp property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("leftExp")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        IExpression LeftExp
        {
            get;
            set;
        }
        
        /// <summary>
        /// The rightExp property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("rightExp")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        IExpression RightExp
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the LeftExp property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LeftExpChanging;
        
        /// <summary>
        /// Gets fired when the LeftExp property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LeftExpChanged;
        
        /// <summary>
        /// Gets fired before the RightExp property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RightExpChanging;
        
        /// <summary>
        /// Gets fired when the RightExp property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RightExpChanged;
    }
}

