﻿// Copyright © Microsoft Corporation.  All Rights Reserved.
// This code released under the terms of the 
// Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)

using System.Windows.Input;
using Microsoft.TeamFoundation.Migration.Shell.Controller;
using Microsoft.TeamFoundation.Migration.Shell.Model;

namespace Microsoft.TeamFoundation.Migration.Shell.View
{
    /// <summary>
    /// Provides a command that starts a migration session defined by the current data model.
    /// </summary>
    public class StartCommand : ViewModelCommand<ShellController, ConfigurationModel>
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="StartCommand&lt;TController, TModel&gt;"/> class.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        public StartCommand (ShellViewModel viewModel)
            : base (viewModel)
        {
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
                return "CanStart";
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
            Execute(this.viewModel as ShellViewModel);
        }

        /// <summary>
        /// Determines whether a data model can be opened for the specified <see cref="ViewModel&lt;TController, TModel&gt;"/>.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <returns>
        /// 	<c>true</c> if a data model can be opened; otherwise, <c>false</c>.
        /// </returns>
        public static bool CanStart (ShellViewModel viewModel)
        {
            return viewModel.CanStart;
        }

        /// <summary>
        /// Starts the migration or synchronization session.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <param name="owner">The owner window.</param>
        /// <param name="openPath">The path from which to open.</param>
        public static void Start (ShellViewModel viewModel)
        {
            viewModel.Start();
        }
        #endregion

        #region Internal Methods
        internal static bool CanExecute (ShellViewModel viewModel)
        {
            return StartCommand.CanStart (viewModel);
        }

        internal static void Execute(ShellViewModel viewModel)
        {
            viewModel.ClearViewModels();

            //To show progress View irrespective of where the user is when Start session is clicked
            viewModel.ShowMigrationView = MigrationStatusViews.Progress;
            StartCommand.Start(viewModel);
        }
        #endregion
    }

    /// <summary>
    /// Provides a <see cref="CommandBinding"/> that delegates the <see cref="ApplicationCommands.Open"/> routed command to the <see cref="StartCommand&lt;TController, TModel&gt;"/>.
    /// </summary>
    /// <typeparam name="TController">The type of the controller.</typeparam>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    public class StartCommandBinding : CommandBinding
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="StartCommandBinding&lt;TController, TModel&gt;"/> class.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        public StartCommandBinding (ShellViewModel viewModel)
        {
            this.Command = MediaCommands.Play;

            StartCommand command = new StartCommand(viewModel);

            this.CanExecute += delegate(object sender, CanExecuteRoutedEventArgs e)
            {
                e.CanExecute = command.CanExecute(e.Parameter);
            };

            this.Executed += delegate(object sender, ExecutedRoutedEventArgs e)
            {
                command.Execute(e.Parameter);
            };
        }
        #endregion
    }
}

