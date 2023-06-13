<?php

namespace App\Http\Livewire;

use Livewire\Component;
use Telegram\Bot\Laravel\Facades\Telegram;

class TestingButton extends Component
{
    public function render()
    {
        return view('livewire.testing-button');
    }

    public function test(){

    }
}
