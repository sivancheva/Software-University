<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_f32ad73c9bc804e7d7685ce925e27ce9c7daa98efc0b9a8c89227d7076a75563 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_3033cd6891ac966e1521a1336ae82886819f7ebcc6422673c6ec7734e82c5406 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_3033cd6891ac966e1521a1336ae82886819f7ebcc6422673c6ec7734e82c5406->enter($__internal_3033cd6891ac966e1521a1336ae82886819f7ebcc6422673c6ec7734e82c5406_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_02f775159dff9badb552115ebbe9a098f1837cc230ec4c75e4d621b1dd755d40 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_02f775159dff9badb552115ebbe9a098f1837cc230ec4c75e4d621b1dd755d40->enter($__internal_02f775159dff9badb552115ebbe9a098f1837cc230ec4c75e4d621b1dd755d40_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_3033cd6891ac966e1521a1336ae82886819f7ebcc6422673c6ec7734e82c5406->leave($__internal_3033cd6891ac966e1521a1336ae82886819f7ebcc6422673c6ec7734e82c5406_prof);

        
        $__internal_02f775159dff9badb552115ebbe9a098f1837cc230ec4c75e4d621b1dd755d40->leave($__internal_02f775159dff9badb552115ebbe9a098f1837cc230ec4c75e4d621b1dd755d40_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_69328464a954e95141ee05fef1dd1bb403dd2ea374b7964bdf899341972f96a7 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_69328464a954e95141ee05fef1dd1bb403dd2ea374b7964bdf899341972f96a7->enter($__internal_69328464a954e95141ee05fef1dd1bb403dd2ea374b7964bdf899341972f96a7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_a6639746818141df05a871a4e1b47f7c8accd61d82d1cd75340c1e796426006d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a6639746818141df05a871a4e1b47f7c8accd61d82d1cd75340c1e796426006d->enter($__internal_a6639746818141df05a871a4e1b47f7c8accd61d82d1cd75340c1e796426006d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_a6639746818141df05a871a4e1b47f7c8accd61d82d1cd75340c1e796426006d->leave($__internal_a6639746818141df05a871a4e1b47f7c8accd61d82d1cd75340c1e796426006d_prof);

        
        $__internal_69328464a954e95141ee05fef1dd1bb403dd2ea374b7964bdf899341972f96a7->leave($__internal_69328464a954e95141ee05fef1dd1bb403dd2ea374b7964bdf899341972f96a7_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_8791989111d1b19862ea73ede435f80de67951b84e0fde8b6a5c781ccb4fb84f = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_8791989111d1b19862ea73ede435f80de67951b84e0fde8b6a5c781ccb4fb84f->enter($__internal_8791989111d1b19862ea73ede435f80de67951b84e0fde8b6a5c781ccb4fb84f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_bb498229eaff0a5e30c3fc3a0940b57f758d24b39ede51c6fcd11436bef9918f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_bb498229eaff0a5e30c3fc3a0940b57f758d24b39ede51c6fcd11436bef9918f->enter($__internal_bb498229eaff0a5e30c3fc3a0940b57f758d24b39ede51c6fcd11436bef9918f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_bb498229eaff0a5e30c3fc3a0940b57f758d24b39ede51c6fcd11436bef9918f->leave($__internal_bb498229eaff0a5e30c3fc3a0940b57f758d24b39ede51c6fcd11436bef9918f_prof);

        
        $__internal_8791989111d1b19862ea73ede435f80de67951b84e0fde8b6a5c781ccb4fb84f->leave($__internal_8791989111d1b19862ea73ede435f80de67951b84e0fde8b6a5c781ccb4fb84f_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_25bdf886987926e15d281fd774f6f35edc11886abaa7b081046541b7b22f73a9 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_25bdf886987926e15d281fd774f6f35edc11886abaa7b081046541b7b22f73a9->enter($__internal_25bdf886987926e15d281fd774f6f35edc11886abaa7b081046541b7b22f73a9_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_fd999ac085508e95e6dca8228347b4ded1dd91189d673c95ac4eddde0747cffb = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_fd999ac085508e95e6dca8228347b4ded1dd91189d673c95ac4eddde0747cffb->enter($__internal_fd999ac085508e95e6dca8228347b4ded1dd91189d673c95ac4eddde0747cffb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_fd999ac085508e95e6dca8228347b4ded1dd91189d673c95ac4eddde0747cffb->leave($__internal_fd999ac085508e95e6dca8228347b4ded1dd91189d673c95ac4eddde0747cffb_prof);

        
        $__internal_25bdf886987926e15d281fd774f6f35edc11886abaa7b081046541b7b22f73a9->leave($__internal_25bdf886987926e15d281fd774f6f35edc11886abaa7b081046541b7b22f73a9_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 33,  135 => 32,  129 => 28,  127 => 27,  123 => 25,  114 => 24,  103 => 21,  97 => 17,  95 => 16,  90 => 14,  85 => 13,  76 => 12,  63 => 9,  57 => 6,  54 => 5,  51 => 4,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
", "@WebProfiler/Collector/exception.html.twig", "C:\\Users\\Ship\\Desktop\\STExam\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}
