﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPMeta2.Definitions;
using SPMeta2.Regression.Model.Definitions;
using SPMeta2.Regression.Tests.Impl.Events;
using SPMeta2.Syntax.Default;

namespace SPMeta2.Regression.Tests.O365.Impl
{
    [TestClass]
    public class DefinitionEventsTest : DefinitionEventsTestBase
    {
        #region tests

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_FieldDefinition()
        {
            ValidateSiteModelEvents<Field>(SPMeta2Model.NewSiteModel(), RegSiteFields.BooleanField);
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_ContentTypeDefinition()
        {
            ValidateSiteModelEvents<ContentType>(SPMeta2Model.NewSiteModel(), RegContentTypes.CustomItem);
        }

        #endregion

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_ContentTypeFieldLinkDefinition()
        {
            ValidateSiteModelEvents<FieldLink>(
                SPMeta2Model.NewSiteModel(site =>
                {
                    site
                        .AddField(RegSiteFields.BooleanField)
                        .AddContentType(RegContentTypes.CustomItem);
                }),
                new ContentTypeFieldLinkDefinition { FieldId = RegSiteFields.BooleanField.Id });
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_ContentTypeLinkDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_FarmDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_FeatureDefinition()
        {
            ValidateSiteModelEvents<Feature>(SPMeta2Model.NewSiteModel(), RegSiteFeatures.PublishingSite);
            ValidateSiteModelEvents<Feature>(SPMeta2Model.NewWebModel(), RegWebFeatures.PublishingWeb);
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_FolderDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_ListDefinition()
        {
            ValidateWebModelEvents<List>(SPMeta2Model.NewWebModel(), RegLists.GenericList);
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_ListItemDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_ListItemFieldValueDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_ListViewDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_ModuleFileDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_PropertyDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_PublishingPageDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_QuickLunchNavigationNodeDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_SecurityGroupDefinition()
        {
            ValidateSiteModelEvents<Group>(SPMeta2Model.NewSiteModel(), RegSecurityGroups.SecurityGroup1);
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_SecurityGroupLinkDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_SecurityRoleDefinition()
        {
            ValidateSiteModelEvents<RoleDefinition>(SPMeta2Model.NewSiteModel(), RegSecurityRoles.SecurityRole1);
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_SecurityRoleLinkDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_SiteDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_SP2013WorkflowDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_SP2013WorkflowSubscriptionDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_UserCustomActionDefinition()
        {
            ValidateSiteModelEvents<UserCustomAction>(SPMeta2Model.NewSiteModel(), RegUserCustomActions.jQueryScript);
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_WebDefinition()
        {
            ValidateWebModelEvents<Web>(SPMeta2Model.NewWebModel(), RegWebs.BlankWeb);
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_WebPartDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_WebPartPageDefinition()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Regression.Events.O365")]
        public override void CanRaiseEvents_WikiPageDefinition()
        {
            throw new NotImplementedException();
        }
    }
}
