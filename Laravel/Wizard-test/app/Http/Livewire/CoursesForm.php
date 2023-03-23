<?php

namespace App\Http\Livewire;

use Livewire\Component;
use App\Models\Courses;
use Illuminate\Http\Request;

class CoursesForm extends Component
{
    public int $currentStep = 1;
    public string $name = '';
    public float $price = 0;
    public string $description = '';
    public bool  $suscriber = false;
    public string $successMsg = '';

    public function render()
    {
        return view('livewire.courses-form')->layout('welcome');
    }

    public function firstStepSubmit() :void
    {
        $this->validate([
            'name' => 'required|min:5',
            'price' => 'required|numeric',
            'description' => 'required|max:255'
        ]);

        $this->currentStep = 2;
    }

    public function secondStepSubmit() : void {
        $this->currentStep= 3;
    }

    public function submitForm(Request $request) :void {
        $course = new Courses();
        $course->CreateCourse($request);

        $this->successMsg='Curso creado correctamente.';
        $this->reset(['name', 'price', 'description', 'suscriber']);
        $this->currentStep = 1;
    }

    public function back(int $step) : void{
        $this->currentStep = $step;
    }
}
