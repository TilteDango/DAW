<?php

namespace App\Http\Livewire;

use Livewire\Component;
use App\Models\Courses;

class CoursesForm extends Component
{

    public $currentStep = 1;
    public $name, $price, $description, $suscriber = false;
    public $successMsg = '';

    public function render()
    {
        return view('livewire.courses-form');
    }

    public function firstStepSubmit()
    {
        $validatedData = $this->validate([
            'name' => 'required|min:5',
            'price' => 'required|numeric',
            'description' => 'required|max:255'
        ]);

        $this->currentStep = 2;
    }

    public function secondStepSubmit(){
        $this->currentStep= 3;
    }

    public function submitForm(){
        Courses::create([
            'name' => $this->name,
            'price' => $this->price,
            'description' => $this->description,
            'suscriber' => $this->suscriber,
        ]);

        $this->successMsg='Curso creado correctamente.';
        $this->clearForm();
        $this->currentStep = 1;
    }

    public function back($step){
        $this->currentStep = $step;
    }

    public function clearForm(){
        $this->name = '';
        $this->price = '';
        $this->description = '';
        $this->suscriber = false;
    }


}
