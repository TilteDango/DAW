<?php

namespace Tests\Feature;

use App\Models\Courses;
use Illuminate\Foundation\Testing\RefreshDatabase;
use Illuminate\Foundation\Testing\WithFaker;
use Livewire\Livewire;
use Tests\TestCase;

class CoursesTest extends TestCase
{
    use RefreshDatabase;

    /** @test */

    function course_page_contains_livewire_component(){
        $this->get('/courses')->assertSee('courses-form');
    }

    /** @test */

    function see_course_name_is_not_empty(){
        Livewire::test('courses-form')
        ->set('name', '')
        ->set('price', 32)
        ->set('description', 'Hola test')
        ->call('firstStepSubmit')
        ->assertHasErrors(['name' => 'required']);
    }

    /** @test */
    function see_course_name_is_min_5(){
        Livewire::test('courses-form')
        ->set('name', 'aaa')
        ->set('price', 32)
        ->set('description', 'Hola test')
        ->call('firstStepSubmit')
        ->assertHasErrors(['name' => 'min']);
    }
        /** @test */
    function see_course_price_is_not_empty(){
        Livewire::test('courses-form')
        ->set('name', 'Laravel')
        ->set('price', 0)
        ->set('description', 'Hola test')
        ->call('firstStepSubmit')
        ->assertHasNoErrors();
    }

        /** @test */
        // function see_course_description_is_max_255(){
        //     Livewire::test('courses-form')
        //     ->set('name', 'Laravel')
        //     ->set('price', 0)
        //     ->set('description', str_repeat('a', 256))
        //     ->call('firstStepSubmit')
        //     ->assertHasErrors(['description', 'max']);
        // }

        /** @test */

        function course_works_properly(){
            Livewire::test('courses-form')
            ->set('name', 'Laravel')
            ->set('price', 0)
            ->set('description', 'Hola test')
            ->call('firstStepSubmit')
            ->assertHasNoErrors();
        }

        /** @test */
      function can_create_courses(){
        Livewire::test('courses-form')
            ->set('name', 'Laravel')
            ->set('price', 0)
            ->set('description', 'Hola test')
            ->set('suscriber', true)
            ->call('submitForm')
            ->assertSee('Curso creado correctamente');
      }
}
