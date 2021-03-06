﻿using System.Collections.Generic;
using System.Reactive;
using GitHub.Models;
using ReactiveUI;
using System.Collections.ObjectModel;

namespace GitHub.ViewModels
{
    /// <summary>
    /// ViewModel for the the Clone Repository dialog
    /// </summary>
    public interface IRepositoryCloneViewModel : IViewModel, IRepositoryCreationTarget
    {
        /// <summary>
        /// Command to clone the currently selected repository.
        /// </summary>
        IReactiveCommand<Unit> CloneCommand { get; }

        /// <summary>
        /// The list of repositories the current user may clone from the specified host.
        /// </summary>
        ObservableCollection<IRemoteRepositoryModel> Repositories { get; }

        IRemoteRepositoryModel SelectedRepository { get; set; }

        bool FilterTextIsEnabled { get; }

        /// <summary>
        /// Whether or not we are currently loading repositories.
        /// </summary>
        bool IsLoading { get; }

        /// <summary>
        /// If true, then we failed to load the repositories.
        /// </summary>
        bool LoadingFailed { get; }

        /// <summary>
        /// Set to true if no repositories were found.
        /// </summary>
        bool NoRepositoriesFound { get; }

        /// <summary>
        /// Set to true if a repository is selected.
        /// </summary>
        bool CanClone { get; }

        string FilterText { get; set; }
    }
}
