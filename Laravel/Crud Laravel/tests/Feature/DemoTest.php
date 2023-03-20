<?php

namespace Tests\Feature;

use Illuminate\Foundation\Testing\RefreshDatabase;
use Illuminate\Foundation\Testing\WithFaker;
use Tests\TestCase;
use Illuminate\Support\Facades\Artisan;
use App\Models\User;
use Illuminate\Support\Facades\Hash;

class DemoTest extends TestCase
{
    public function test_registrer(){

        Artisan::call('migrate');

        //El formulario carga correctamente
        $carga = $this->get(route('register'));
        $carga->assertStatus(200)->assertSee('Registrarse');

        //Registro incorrecto
        $registroMal = $this->post(route('do-register', ["email" => "aaa", "password" => "123"]));
        $registroMal->assertStatus(302)->assertRedirect(route('register'))->assertSessionHasErrors();

        //Registro correcto
        $registroBien = $this->post(route('do-register'), ['email' => 'test@testing.es', 'password' => "Password1", 'name' => "Testing"]);
        $registroBien->assertStatus(302)->assertRedirect(route('home'));
        $this->assertDatabaseHas('users', ['email' => 'test@testing.es']);

        //Registro repetido
        $registroRepetido = $this->post(route('do-register', ["email" => "aaa", "password" => "123"]));
        $registroRepetido->assertStatus(302)->assertRedirect(route('register'))->assertSessionHasErrors();
    }

    public function test_login(){
        Artisan::call('migrate');

        //Crear el usuario para hacer las comprobaciones

        User::create(['name' => 'Test', 'email' => 'test@testing.es', 'password' => Hash::make('Password1')]);

        //Resto de tests
    }
}
