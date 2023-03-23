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
        return view('livewire.wizard')->layout('wizard');
    }

    public function firstStepSubmit()
    {
        $validatedData = $this->validate([
            'name' => 'required',
            'price' => 'required|numeric',
            'detail' => 'required',
        ]);

        $this->currentStep = 2;
    }

    public function secondStepSubmit()
    {
        $validatedData = $this->validate([
            'status' => 'required',
        ]);

        $this->currentStep = 3;
    }

    public function submitForm(Request $request)
    {
        $team = new Team();
        $team->CreateTeam($request);

        $this->successMsg = 'Team successfully created.';

        $this->reset(['name', 'price', 'detail', 'status']);

        $this->currentStep = 1;
    }

    public function back( int $step)
    {
        $this->currentStep = $step;
    }


    public function clearForm()
    {
        $this->name = '';
        $this->price = '';
        $this->detail = '';
        $this->status = 1;
    }
}
