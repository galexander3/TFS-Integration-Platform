﻿// Copyright © Microsoft Corporation.  All Rights Reserved.
// This code released under the terms of the 
// Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)

using System;
using System.Windows;
using System.Windows.Input;
using Microsoft.TeamFoundation.Migration.Shell.Controller;
using Microsoft.TeamFoundation.Migration.Shell.Model;

namespace Microsoft.TeamFoundation.Migration.Shell.View
{
    /// <summary>
    /// Provides a command that opens the current data model.
    /// </summary>
    /// <typeparam name="TController">The type of the controller.</typeparam>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    public class ViewConfigurationCommand : ViewModelCommand<ShellController, ConfigurationModel>
    {
        #region Fields
        private readonly Window m_owner;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenFromDBCommand&lt;TController, TModel&gt;"/> class.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        public ViewConfigurationCommand (ShellViewModel viewModel)
            : this (viewModel, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenFromDBCommand&lt;TController, TModel&gt;"/> class.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <param name="owner">The owner window.</param>
        public ViewConfigurationCommand(ShellViewModel viewModel, Window owner)
            : base (viewModel)
        {
            this.m_owner = owner;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the name of the view model property that determines whether this command can be executed.
        /// </summary>
        /// <value></value>
        protected override string ViewModelPropertyName
        {
            get
            {
                return "CanViewConfiguration";
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        /// <returns>
        /// true if this command can be executed; otherwise, false.
        /// </returns>
        public override bool CanExecute (object parameter)
        {
            return CanExecute(this.viewModel as ShellViewModel);
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public override void Execute (object parameter)
        {
            Execute(this.viewModel as ShellViewModel, this.m_owner);
        }

        /// <summary>
        /// Determines whether a data model can be opened for the specified <see cref="ViewModel&lt;TController, TModel&gt;"/>.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <returns>
        /// 	<c>true</c> if a data model can be opened; otherwise, <c>false</c>.
        /// </returns>
        public static bool CanOpen (ShellViewModel viewModel)
        {
            return viewModel.IsDataModelLoaded;
        } 

        /// <summary>
        /// Opens a data model for the specified <see cref="ViewModel&lt;TController, TModel&gt;"/>.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <param name="owner">The owner window.</param>
        /// <param name="openPath">The path from which to open.</param>
        public static void Open (ShellViewModel viewModel, Window owner)
        {
            if (viewModel.ConfigViewModel != null)
            {
                viewModel.PushViewModel(viewModel.ConfigViewModel);
                viewModel.SystemState = SystemState.EditConfiguration;
                viewModel.ShowMigrationView = MigrationStatusViews.Progress;
            }
            else
            {
                Utilities.HandleException(new Exception("Could not open configuration file."), false, "Open Error", "Invalid XML");
            }
        }

        #endregion

        #region Internal Methods
        internal static bool CanExecute (ShellViewModel viewModel)
        {
            return ViewConfigurationCommand.CanOpen(viewModel);
        }

        internal static void Execute (ShellViewModel viewModel, Window owner)
        {
            ViewConfigurationCommand.Open(viewModel, owner);
        }
        #endregion
    }

    /// <summary>
    /// Provides a <see cref="CommandBinding"/> that delegates the <see cref="ApplicationCommands.Open"/> routed command to the <see cref="OpenFromDBCommand&lt;TController, TModel&gt;"/>.
    /// </summary>
    /// <typeparam name="TController">The type of the controller.</typeparam>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    public class ViewConfigurationCommandBinding : CommandBinding
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenFromDBCommandBinding&lt;TController, TModel&gt;"/> class.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        public ViewConfigurationCommandBinding (ShellViewModel viewModel)
            : this (viewModel, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenFromDBCommandBinding&lt;TController, TModel&gt;"/> class.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <param name="owner">The owner window.</param>
        public ViewConfigurationCommandBinding(ShellViewModel viewModel, Window owner)
        {
            this.Command = ShellCommands.ViewConfiguration;

            this.CanExecute += delegate (object sender, CanExecuteRoutedEventArgs e)
            {
                e.CanExecute = ViewConfigurationCommand.CanExecute(viewModel);
            };

            this.Executed += delegate (object sender, ExecutedRoutedEventArgs e)
            {
                ViewConfigurationCommand.Execute(viewModel, owner);
            };
        }
        #endregion
    }
}