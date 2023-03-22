<?php

namespace App\Http\Livewire;

use Livewire\Component;
use App\Models\Courses;
use Illuminate\Http\Request;

class CoursesForm extends Component
{

    public Float $currentStep = 1;
    public $name, $price, $description, $suscriber = false;
    public String $successMsg = '';

    public function render()
    {
        return view('livewire.courses-form')->layout('welcome');
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

    public function submitForm(Request $request) {
        $course = Courses::create($request->all());

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
