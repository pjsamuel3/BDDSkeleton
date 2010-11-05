using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BDDSkeleton.GUI.Presenters;
using BDDSkeleton.GUI.Views;
using BDDSkeleton.GUI.Tests.Mocks;
using BDD;

namespace BDDSkeleton.GUI.Tests.Presenters
{
    [TestClass]
    public class HelloWorldPresenterTest : BDD<HelloWorldPresenterTest>
    {

        [TestInitialize]
        public void Setup()
        {
            Given.We_Have_A_Presenter();
        }

        [TestMethod]
        public void Can_Create_Instance_Of_Hello_World_Presenter()
        {
            Then.presenter.ShouldNotBeNull();
        }

        [TestMethod]
        public void Can_Display_A_Message()
        {
            When.User_Clicks();
            Then.Something_Happens_To_The_View();
            And.The_Message_Shown_Is_What_We_Expected();
        }

        private HelloWorldPresenter presenter;
        private HelloWorldViewMock view;

        private void We_Have_A_Presenter()
        {
            view = new HelloWorldViewMock();
            presenter = new HelloWorldPresenter(view);
        }

        private void User_Clicks()
        {
            presenter.User_Clicked_Button();
        }

        private void Something_Happens_To_The_View()
        {
            view.ShowMessageWasCalled.ShouldBeTrue();
        }

        private void The_Message_Shown_Is_What_We_Expected()
        {
            view.MessageShown.ShouldBeginWith("Hello World");
        }
    }
}
