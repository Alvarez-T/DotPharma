﻿using CommunityToolkit.Mvvm.ComponentModel;
using NavigatR.MVVM;

namespace DotPharma.Presentation.ViewModels.Tiles;

public partial class RegisterMedicationViewModel : ObservableObject, IViewModelTile
{
    [ObservableProperty] private string _medicationGroupSearched;
    [ObservableProperty] private string _prescription;
}
