<?php

namespace App\Http\Livewire;
use Livewire\Component;
use App\Models\Team;
use Illuminate\Http\Request;

class Wizard extends Component
{
    public int $currentStep = 1;
    public string $name = '';
    public float $price = 0;
    public string $detail = '';
    public int $status = 1;
    public string $successMsg = '';

    public function render()
    {
        return view('livewire.wizard')->layout('welcome');
    }

    public function firstStepSubmit() : void
    {
        $this->validate([
            'name' => 'required',
            'price' => 'required|numeric',
            'detail' => 'required',
        ]);

        $this->currentStep = 2;
    }

    public function secondStepSubmit() : void
    {
        $this->validate([
            'status' => 'required',
        ]);

        $this->currentStep = 3;
    }

    public function submitForm(Request $request) :void
    {
        $team = new Team();
        $team->CreateTeam($request);
        $this->successMsg = 'Team successfully created.';
        $this->reset(['name', 'price', 'detail', 'status']);
        $this->currentStep = 1;
    }

    public function back(int $step) : void
    {
        $this->currentStep = $step;
    }
}
