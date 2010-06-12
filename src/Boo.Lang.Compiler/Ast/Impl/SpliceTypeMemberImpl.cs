#region license
// Copyright (c) 2009 Rodrigo B. de Oliveira (rbo@acm.org)
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice,
//     this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution.
//     * Neither the name of Rodrigo B. de Oliveira nor the names of its
//     contributors may be used to endorse or promote products derived from this
//     software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
// THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by astgen.boo.
//
namespace Boo.Lang.Compiler.Ast
{	
	using System.Collections;
	using System.Runtime.Serialization;
	
	[System.Serializable]
	public partial class SpliceTypeMember : TypeMember
	{
		protected TypeMember _typeMember;

		protected Expression _nameExpression;


		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		new public SpliceTypeMember CloneNode()
		{
			return (SpliceTypeMember)Clone();
		}
		
		/// <summary>
		/// <see cref="Node.CleanClone"/>
		/// </summary>
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		new public SpliceTypeMember CleanClone()
		{
			return (SpliceTypeMember)base.CleanClone();
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public NodeType NodeType
		{
			get
			{
				return NodeType.SpliceTypeMember;
			}
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public void Accept(IAstVisitor visitor)
		{
			visitor.OnSpliceTypeMember(this);
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public bool Matches(Node node)
		{	
			SpliceTypeMember other = node as SpliceTypeMember;
			if (null == other) return false;
			if (_modifiers != other._modifiers) return NoMatch("SpliceTypeMember._modifiers");
			if (_name != other._name) return NoMatch("SpliceTypeMember._name");
			if (!Node.AllMatch(_attributes, other._attributes)) return NoMatch("SpliceTypeMember._attributes");
			if (!Node.Matches(_typeMember, other._typeMember)) return NoMatch("SpliceTypeMember._typeMember");
			if (!Node.Matches(_nameExpression, other._nameExpression)) return NoMatch("SpliceTypeMember._nameExpression");
			return true;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}
			if (_attributes != null)
			{
				Attribute item = existing as Attribute;
				if (null != item)
				{
					Attribute newItem = (Attribute)newNode;
					if (_attributes.Replace(item, newItem))
					{
						return true;
					}
				}
			}
			if (_typeMember == existing)
			{
				this.TypeMember = (TypeMember)newNode;
				return true;
			}
			if (_nameExpression == existing)
			{
				this.NameExpression = (Expression)newNode;
				return true;
			}
			return false;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public object Clone()
		{
			SpliceTypeMember clone = (SpliceTypeMember)FormatterServices.GetUninitializedObject(typeof(SpliceTypeMember));
			clone._lexicalInfo = _lexicalInfo;
			clone._endSourceLocation = _endSourceLocation;
			clone._documentation = _documentation;
			clone._entity = _entity;
			if (_annotations != null) clone._annotations = (Hashtable)_annotations.Clone();
		
			clone._modifiers = _modifiers;
			clone._name = _name;
			if (null != _attributes)
			{
				clone._attributes = _attributes.Clone() as AttributeCollection;
				clone._attributes.InitializeParent(clone);
			}
			if (null != _typeMember)
			{
				clone._typeMember = _typeMember.Clone() as TypeMember;
				clone._typeMember.InitializeParent(clone);
			}
			if (null != _nameExpression)
			{
				clone._nameExpression = _nameExpression.Clone() as Expression;
				clone._nameExpression.InitializeParent(clone);
			}
			return clone;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override internal void ClearTypeSystemBindings()
		{
			_annotations = null;
			_entity = null;
			if (null != _attributes)
			{
				_attributes.ClearTypeSystemBindings();
			}
			if (null != _typeMember)
			{
				_typeMember.ClearTypeSystemBindings();
			}
			if (null != _nameExpression)
			{
				_nameExpression.ClearTypeSystemBindings();
			}

		}
	

		[System.Xml.Serialization.XmlElement]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		public TypeMember TypeMember
		{
			get
			{

				return _typeMember;
			}

			set
			{
				if (_typeMember != value)
				{
					_typeMember = value;
					if (null != _typeMember)
					{
						_typeMember.InitializeParent(this);
					}
				}
			}

		}
		

		[System.Xml.Serialization.XmlElement]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		public Expression NameExpression
		{
			get
			{

				return _nameExpression;
			}

			set
			{
				if (_nameExpression != value)
				{
					_nameExpression = value;
					if (null != _nameExpression)
					{
						_nameExpression.InitializeParent(this);
					}
				}
			}

		}
		

	}
}

