//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "3a0d33fc834c91b6")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.2")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, IBasicContentControls, IBasicTitleControls, IFooterContentControls, IMainTitleImageControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Main Content: Enter the main content of this page
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetMainContent(this); }
		}

		///<summary>
		/// Page Title: Enter page title. If left blank, the name of the page will be used
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.BasicTitleControls.GetPageTitle(this); }
		}

		///<summary>
		/// Subtitle: Enter the subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return Umbraco.Web.PublishedContentModels.BasicTitleControls.GetSubtitle(this); }
		}

		///<summary>
		/// Title Link: Enter the link for title and subtitle
		///</summary>
		[ImplementPropertyType("titleLink")]
		public Umbraco.Web.Models.RelatedLinks TitleLink
		{
			get { return Umbraco.Web.PublishedContentModels.BasicTitleControls.GetTitleLink(this); }
		}

		///<summary>
		/// Footer Content: Enter the content for the footer
		///</summary>
		[ImplementPropertyType("footerContent")]
		public IHtmlString FooterContent
		{
			get { return Umbraco.Web.PublishedContentModels.FooterContentControls.GetFooterContent(this); }
		}

		///<summary>
		/// Footer Social List
		///</summary>
		[ImplementPropertyType("footerSocialList")]
		public Umbraco.Web.Models.RelatedLinks FooterSocialList
		{
			get { return Umbraco.Web.PublishedContentModels.FooterContentControls.GetFooterSocialList(this); }
		}

		///<summary>
		/// Footer Title: Enter title for the footer
		///</summary>
		[ImplementPropertyType("footerTitle")]
		public string FooterTitle
		{
			get { return Umbraco.Web.PublishedContentModels.FooterContentControls.GetFooterTitle(this); }
		}

		///<summary>
		/// Main Image: Please choose an image to show under the title
		///</summary>
		[ImplementPropertyType("mainImage")]
		public IPublishedContent MainImage
		{
			get { return Umbraco.Web.PublishedContentModels.MainTitleImageControls.GetMainImage(this); }
		}
	}

	/// <summary>Content</summary>
	[PublishedContentModel("content")]
	public partial class Content : PublishedContentModel, IBasicContentControls, IBasicTitleControls, IMainTitleImageControls, IUmbracoUrlAliasControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "content";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Content(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Content, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Main Content: Enter the main content of this page
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetMainContent(this); }
		}

		///<summary>
		/// Page Title: Enter page title. If left blank, the name of the page will be used
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.BasicTitleControls.GetPageTitle(this); }
		}

		///<summary>
		/// Subtitle: Enter the subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return Umbraco.Web.PublishedContentModels.BasicTitleControls.GetSubtitle(this); }
		}

		///<summary>
		/// Title Link: Enter the link for title and subtitle
		///</summary>
		[ImplementPropertyType("titleLink")]
		public Umbraco.Web.Models.RelatedLinks TitleLink
		{
			get { return Umbraco.Web.PublishedContentModels.BasicTitleControls.GetTitleLink(this); }
		}

		///<summary>
		/// Main Image: Please choose an image to show under the title
		///</summary>
		[ImplementPropertyType("mainImage")]
		public IPublishedContent MainImage
		{
			get { return Umbraco.Web.PublishedContentModels.MainTitleImageControls.GetMainImage(this); }
		}

		///<summary>
		/// Umbraco Url Alias: Enter an alternative URL. Please note that the values you use must be lowercase, not use a leading slash and not use a trailing ".aspx" or trailing slash. If you are adding multiple values, they must be separated with a comma.
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoUrlAliasControls.GetUmbracoUrlAlias(this); }
		}
	}

	// Mixin content Type 1059 with alias "umbracoUrlAliasControls"
	/// <summary>Umbraco Url Alias Controls</summary>
	public partial interface IUmbracoUrlAliasControls : IPublishedContent
	{
		/// <summary>Umbraco Url Alias</summary>
		string UmbracoUrlAlias { get; }
	}

	/// <summary>Umbraco Url Alias Controls</summary>
	[PublishedContentModel("umbracoUrlAliasControls")]
	public partial class UmbracoUrlAliasControls : PublishedContentModel, IUmbracoUrlAliasControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbracoUrlAliasControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbracoUrlAliasControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbracoUrlAliasControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Umbraco Url Alias: Enter an alternative URL. Please note that the values you use must be lowercase, not use a leading slash and not use a trailing ".aspx" or trailing slash. If you are adding multiple values, they must be separated with a comma.
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return GetUmbracoUrlAlias(this); }
		}

		/// <summary>Static getter for Umbraco Url Alias</summary>
		public static string GetUmbracoUrlAlias(IUmbracoUrlAliasControls that) { return that.GetPropertyValue<string>("umbracoUrlAlias"); }
	}

	// Mixin content Type 1060 with alias "basicTitleControls"
	/// <summary>Basic Title Controls</summary>
	public partial interface IBasicTitleControls : IPublishedContent
	{
		/// <summary>Page Title</summary>
		string PageTitle { get; }

		/// <summary>Subtitle</summary>
		string Subtitle { get; }

		/// <summary>Title Link</summary>
		Umbraco.Web.Models.RelatedLinks TitleLink { get; }
	}

	/// <summary>Basic Title Controls</summary>
	[PublishedContentModel("basicTitleControls")]
	public partial class BasicTitleControls : PublishedContentModel, IBasicTitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "basicTitleControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BasicTitleControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BasicTitleControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Page Title: Enter page title. If left blank, the name of the page will be used
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return GetPageTitle(this); }
		}

		/// <summary>Static getter for Page Title</summary>
		public static string GetPageTitle(IBasicTitleControls that) { return that.GetPropertyValue<string>("pageTitle"); }

		///<summary>
		/// Subtitle: Enter the subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return GetSubtitle(this); }
		}

		/// <summary>Static getter for Subtitle</summary>
		public static string GetSubtitle(IBasicTitleControls that) { return that.GetPropertyValue<string>("subtitle"); }

		///<summary>
		/// Title Link: Enter the link for title and subtitle
		///</summary>
		[ImplementPropertyType("titleLink")]
		public Umbraco.Web.Models.RelatedLinks TitleLink
		{
			get { return GetTitleLink(this); }
		}

		/// <summary>Static getter for Title Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetTitleLink(IBasicTitleControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("titleLink"); }
	}

	// Mixin content Type 1061 with alias "mainTitleImageControls"
	/// <summary>Main Title Image Controls</summary>
	public partial interface IMainTitleImageControls : IPublishedContent
	{
		/// <summary>Main Image</summary>
		IPublishedContent MainImage { get; }
	}

	/// <summary>Main Title Image Controls</summary>
	[PublishedContentModel("mainTitleImageControls")]
	public partial class MainTitleImageControls : PublishedContentModel, IMainTitleImageControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "mainTitleImageControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public MainTitleImageControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MainTitleImageControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Main Image: Please choose an image to show under the title
		///</summary>
		[ImplementPropertyType("mainImage")]
		public IPublishedContent MainImage
		{
			get { return GetMainImage(this); }
		}

		/// <summary>Static getter for Main Image</summary>
		public static IPublishedContent GetMainImage(IMainTitleImageControls that) { return that.GetPropertyValue<IPublishedContent>("mainImage"); }
	}

	// Mixin content Type 1066 with alias "basicContentControls"
	/// <summary>Basic Content Controls</summary>
	public partial interface IBasicContentControls : IPublishedContent
	{
		/// <summary>Main Content</summary>
		IHtmlString MainContent { get; }
	}

	/// <summary>Basic Content Controls</summary>
	[PublishedContentModel("basicContentControls")]
	public partial class BasicContentControls : PublishedContentModel, IBasicContentControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "basicContentControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BasicContentControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BasicContentControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Main Content: Enter the main content of this page
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return GetMainContent(this); }
		}

		/// <summary>Static getter for Main Content</summary>
		public static IHtmlString GetMainContent(IBasicContentControls that) { return that.GetPropertyValue<IHtmlString>("mainContent"); }
	}

	// Mixin content Type 1067 with alias "footerContentControls"
	/// <summary>Footer Content Controls</summary>
	public partial interface IFooterContentControls : IPublishedContent
	{
		/// <summary>Footer Content</summary>
		IHtmlString FooterContent { get; }

		/// <summary>Footer Social List</summary>
		Umbraco.Web.Models.RelatedLinks FooterSocialList { get; }

		/// <summary>Footer Title</summary>
		string FooterTitle { get; }
	}

	/// <summary>Footer Content Controls</summary>
	[PublishedContentModel("footerContentControls")]
	public partial class FooterContentControls : PublishedContentModel, IFooterContentControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "footerContentControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public FooterContentControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FooterContentControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Footer Content: Enter the content for the footer
		///</summary>
		[ImplementPropertyType("footerContent")]
		public IHtmlString FooterContent
		{
			get { return GetFooterContent(this); }
		}

		/// <summary>Static getter for Footer Content</summary>
		public static IHtmlString GetFooterContent(IFooterContentControls that) { return that.GetPropertyValue<IHtmlString>("footerContent"); }

		///<summary>
		/// Footer Social List
		///</summary>
		[ImplementPropertyType("footerSocialList")]
		public Umbraco.Web.Models.RelatedLinks FooterSocialList
		{
			get { return GetFooterSocialList(this); }
		}

		/// <summary>Static getter for Footer Social List</summary>
		public static Umbraco.Web.Models.RelatedLinks GetFooterSocialList(IFooterContentControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("footerSocialList"); }

		///<summary>
		/// Footer Title: Enter title for the footer
		///</summary>
		[ImplementPropertyType("footerTitle")]
		public string FooterTitle
		{
			get { return GetFooterTitle(this); }
		}

		/// <summary>Static getter for Footer Title</summary>
		public static string GetFooterTitle(IFooterContentControls that) { return that.GetPropertyValue<string>("footerTitle"); }
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
